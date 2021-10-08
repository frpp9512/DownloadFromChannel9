using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Data.Models
{
    public record MediaFile
    {
        public Uri Url { get; set; }
        public int Duration { get; set; }
        public uint FileSize { get; set; }
        public MediaType MediaType { get; set; }
        public string MediaTypeFormat { get; set; }


        public double DurationInMinutes => Duration / 60;
        public double FileSizeMB => FileSize / 1024 / 1024;

        public override string ToString()
        {
            return $"{MediaType}-{FileSizeMB} MB";
        }
    }

    public enum MediaType
    {
        Image,
        Audio,
        Video
    }

    public static class MediaTypeConstants
    {
        public static string VideoMp4 = "video/mp4";
        public static string AudioMp3 = "audio/mp3";
        public static string ImageJpg = "image/jpg";
        public static string ImagePng = "image/png";
    }
}
