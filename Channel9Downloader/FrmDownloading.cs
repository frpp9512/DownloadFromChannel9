using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Channel9Downloader
{
    public partial class FrmDownloading : Form
    {
        public event EventHandler RequestingCancel = null;

        public FrmDownloading()
        {
            InitializeComponent();
        }

        public void SetDownload(FileToDownload download, string downloadFolder)
        {
            lbFilename.Text = Path.Combine(downloadFolder, download.Name);
            lbUrl.Text = download.File.Url.AbsoluteUri;
            pbProgress.Value = 0;
        }

        public void SetCompletionPercent(int percent, long bytesDownloaded, long bytesToDownload)
        {
            pbProgress.Value = percent;
            lbProgress.Text = $"{percent} % ({bytesToDownload}/{bytesDownloaded})";
        }

        private void btnRequestCancel_Click(object sender, EventArgs e)
        {
            btnRequestCancel.Enabled = false;
            RequestingCancel?.Invoke(this, new EventArgs());
        }
    }
}
