using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFromChannel9
{
    public record ITunesData
    {
        public string summary { get; set; }
        public int duration { get; set; }
    }
}
