using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Data.Models
{
    public record MediaThumbnail
    {
        public Uri Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
