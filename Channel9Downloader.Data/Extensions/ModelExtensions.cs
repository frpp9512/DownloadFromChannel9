using Channel9Downloader.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Data.Extensions
{
    public static class ModelExtensions
    {
        public static Channel GetChannel(this rssChannel channel)
            => new()
            {
                Author = channel.author,
                Category = channel.category.text,
                Description = channel.description,
                Email = channel.email,
                Image = new Uri(channel.image.url),
                Language = channel.language,
                Link = new Uri(channel.link.href),
                PubDate = DateTime.Parse(channel.pubDate),
                Summary = channel.summary,
                Title = channel.title,
                TotalMedia = channel.totalResults,
                MediaContents = channel.item.Select(i => i.GetMediaContent()).ToArray()
            };

        public static MediaContent GetMediaContent(this rssChannelItem item)
            => new()
            {
                Author = item.author,
                Categories = item.category,
                Comment = item.comments,
                Creator = item.creator,
                Description = item.description,
                Guid = item.guid.Value,
                Link = new Uri(item.link),
                PubDate = DateTime.Parse(item.pubDate),
                Title = item.title,
                Thumbnails = item.thumbnail.Select(t => t.GetMediaThumbnail()).ToArray(),
                MediaFiles = item.group.Select(g => g.GetMediaFile()).ToArray()
            };

        public static MediaThumbnail GetMediaThumbnail(this thumbnail thumbnail)
            => new()
            {
                Url = new Uri(thumbnail.url),
                Height = thumbnail.height,
                Width = thumbnail.width
            };

        public static MediaFile GetMediaFile(this groupContent group)
            => new()
            {
                Duration = group.duration,
                FileSize = group.fileSize,
                MediaType = group.medium switch { "audio" => MediaType.Audio, "video" => MediaType.Video, "image" => MediaType.Image, _ => throw new Exception("Error in media type.") },
                MediaTypeFormat = group.type,
                Url = new Uri(group.url)
            };
    }
}