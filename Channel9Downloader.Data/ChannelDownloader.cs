using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using Channel9Downloader.Data.Extensions;
using Channel9Downloader.Data.Models;

namespace Channel9Downloader.Data
{
    public class ChannelDownloader
    {
        private WebClient _client;

        public void LoadChannelInfoAsync(string url, Action<long, long, int> percentChangeCallback, Action<string, Channel, string> onCompletedCallback)
        {
            using var client = new WebClient();

            client.DownloadProgressChanged += (s, a) => percentChangeCallback(a.BytesReceived, a.TotalBytesToReceive, a.ProgressPercentage);

            client.DownloadDataCompleted += (s, a) =>
            {
                var completion = a.Cancelled ? "cancelled" : a.Error is not null ? "error" : "ok";
                Channel dataResponse = null;
                if (completion == "ok")
                {
                    var serializer = new XmlSerializer(typeof(rss));
                    using var stream = new MemoryStream(a.Result);
                    var response = (rss)serializer.Deserialize(stream);
                    dataResponse = response.channel.GetChannel();
                }
                onCompletedCallback(a.Cancelled ? "cancelled" : a.Error is not null ? "error" : "ok", dataResponse, a.Error?.Message);
            };

            client.DownloadDataAsync(new Uri(url));
        }

        public void DownloadMediaFile(MediaFile fileToDownload, string filePath, Action<long, long, int> percentChangeCallback, Action<string> onCompletedCallback)
        {
            _client = new WebClient();

            _client.DownloadProgressChanged += (s, a) => percentChangeCallback(a.BytesReceived, a.TotalBytesToReceive, a.ProgressPercentage);

            _client.DownloadFileCompleted += (s, a) => 
            {
                var completion = "ok";
                if (a.Cancelled)
                {
                    _client.Dispose();
                    completion = "cancelled";
                }
                if (a.Error is not null)
                {
                    completion = a.Error.Message;
                }
                onCompletedCallback(completion);
                _client.Dispose();
            };

             _client.DownloadFileAsync(fileToDownload.Url, filePath);
        }

        public void CancelFileDownload()
        {
            _client.CancelAsync();
        }
    }
}
