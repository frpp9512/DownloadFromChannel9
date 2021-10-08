using System;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace DownloadFromChannel9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new WebClient();
            var url = "https://s.ch9.ms/Series/Beginners-Series-to-Blazor/rss";
            var data = client.DownloadData(url);
            var stringData = Encoding.UTF8.GetString(data);
            var serializer = new XmlSerializer(typeof(object));
        }
    }
}
