using Channel9Downloader.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader
{
    public class FileToDownload
    {
        public MediaContent MediaContent { get; set; }
        public MediaFile File { get; set; }
        public string Name
        {
            get
            {
                var name = MediaContent.Title;
                foreach (var invalidChar in Path.GetInvalidFileNameChars())
                {
                    name = name.Replace(invalidChar, '_');
                }
                return $"{name}.{File.MediaTypeFormat.Split("/").Last()}";
            }
        }

        public override string ToString()
        {
            return $"[{File.FileSizeMB} MB]{MediaContent.Title}";
        }
    }
}
