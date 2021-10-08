using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Data.Models
{
    public record Channel
    {
        public string Title { get; set; }
        public Uri Link { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public Uri Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTimeOffset PubDate { get; set; }
        public int TotalMedia { get; set; }
        public MediaContent[] MediaContents { get; set; }
    }
}
