using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Data.Models
{
    public class MediaContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public string Creator { get; set; }
        public Uri Link { get; set; }
        public DateTimeOffset PubDate { get; set; }
        public string Guid { get; set; }
        public MediaThumbnail[] Thumbnails { get; set; }
        public MediaFile[] MediaFiles { get; set; }
        public string[] Categories { get; set; }
    }
}
