using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Channel9Downloader.Data;
using Channel9Downloader.Data.Models;

namespace Channel9Downloader
{
    public partial class Form1 : Form
    {
        private ChannelDownloader _downloader;
        private MediaContent _selectedContent;
        private Queue<FileToDownload> _downloadList;
        private FrmDownloading _frmDownloading;
        private bool _downloading;

        public Form1()
        {
            InitializeComponent();
            _downloader = new ChannelDownloader();
            _downloadList = new Queue<FileToDownload>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadContent_Click(object sender, EventArgs e)
        {
            var inputedUrl = txtUrl.Text.Trim();
            if (!ValidateWebUrl(inputedUrl))
            {
                MessageBox.Show("La URL no esta escrita correctamente.", "Error de URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!(inputedUrl.EndsWith("/feed") || inputedUrl.EndsWith("/rss")))
                {
                    var sufix = inputedUrl.EndsWith("/") ? "rss" : "/rss";
                    inputedUrl += sufix;
                }
                ShowStatusProgressBar();
                SetStatusProgressBarValue(0);
                SetStatusActionLabel("Iniciando la descarga del feed...");
                _downloader.LoadChannelInfoAsync(inputedUrl,
                                                 (bytesDownloaded, totalBytes, percent) => 
                                                 {
                                                     SetStatusProgressBarValue(percent);
                                                     SetStatusActionLabel($"Descargando feed ({bytesDownloaded}/{totalBytes}) {percent} %...");
                                                 },
                                                 (completionMessage, dataResponse, errorMessage) => 
                                                 {
                                                     HideStatusProgressBar();
                                                     switch (completionMessage)
                                                     {
                                                         case "error":
                                                             MessageBox.Show(errorMessage, "Error obteniendo contenidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                             SetStatusActionLabel($"Error: {errorMessage}");
                                                             break;
                                                         case "ok":
                                                             SetStatusActionLabel("Descarga del feed completada");
                                                             SetChannelInfo(dataResponse);
                                                             SetMediaContentList(dataResponse.MediaContents);
                                                             break;
                                                         default:
                                                             break;
                                                     }
                                                 });
            }
        }

        private void ShowStatusProgressBar()
            => stpbProgress.Visible = true;

        private void HideStatusProgressBar()
            => stpbProgress.Visible = false;

        private void SetStatusProgressBarValue(int value)
            => stpbProgress.Value = value;

        private void SetStatusActionLabel(string message)
            => stlbAction.Text = message;

        private void SetChannelInfo(Channel channel)
        {
            pbChannelImage.ImageLocation = channel.Image.AbsoluteUri;
            lbChannelTitle.Text = channel.Title;
            lbChannelAuthor.Text = channel.Author;
            lbChannelCategory.Text = channel.Category;
            lbChannelEmail.Text = channel.Email;
            lbChannelLang.Text = channel.Language;
            lbChannelPubDate.Text = channel.PubDate.DateTime.ToShortDateString();
            lbChannelTotalMedia.Text = channel.TotalMedia.ToString();
            
            lbChannelUrl.Text = channel.Link.AbsoluteUri;
            txtChannelSummary.Text = channel.Summary;
        }


        private void SetMediaContentList(MediaContent[] contents)
        {
            lbxContentMedia.DataSource = contents;
            lbxContentMedia.DisplayMember = "Title";
        }

        private bool ValidateWebUrl(string url) 
            => Regex.IsMatch(url, @"http[s]*:\/\/(([-_\w]+)\.*)+(\/([-_\w]+)\.*)*(\?([-_\w]+=[\w\d\-_+\.]+&*)*)*");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbxContentMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContentMedia.SelectedItem is not null)
            {
                var selected = lbxContentMedia.SelectedItem as MediaContent;
                lbxContentMedia.Enabled = false;
                _selectedContent = selected;
                UpdateSelectedContentDetails();
                lbxContentMedia.Enabled = true;
            }
        }

        private void UpdateSelectedContentDetails()
        {
            if (_selectedContent != null)
            {
                SetMediaContentDetails(_selectedContent);
            }
        }

        private void SetFileToDownloadPreview(FileToDownload fileToDownload)
        {
            cbSelectedMediaFiles.DataSource = new MediaFile[] { fileToDownload.File };
            SetMediaContentDetails(fileToDownload.MediaContent, true);
        }

        private void SetMediaContentDetails(MediaContent content, bool onlyPreview = false)
        {
            pbThumbnail.ImageLocation = content.Thumbnails.Last().Url.AbsoluteUri;
            lbSelectedTitle.Text = content.Title;
            txtSelectedDescription.Text = content.Description;
            lbSelectedComment.Text = content.Comment;
            lbSelectedAuthor.Text = content.Author;
            lbSelectedCreator.Text = content.Creator;
            lbSelectedLink.Text = content.Link.AbsoluteUri;
            lbSelectedGuid.Text = content.Guid;

            if (onlyPreview)
            {
                cbSelectedMediaFiles.Enabled = false;
                btnAddToDownloadList.Enabled = false;
            }
            else
            {
                cbSelectedMediaFiles.Enabled = true;
                btnAddToDownloadList.Enabled = true;
                cbSelectedMediaFiles.DataSource = content.MediaFiles.Where(f => f.FileSizeMB > 0).OrderByDescending(f => f.FileSizeMB).ToArray();
            }
        }

        private void cbSelectedMediaFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectedMediaFiles.SelectedItem is not null)
            {
                var selected = cbSelectedMediaFiles.SelectedItem as MediaFile;
                var descriptionBuilder = new StringBuilder();
                descriptionBuilder.AppendLine($"Duración: {selected.DurationInMinutes} min ");
                descriptionBuilder.AppendLine($"Tamaño: {selected.FileSizeMB} MB");
                descriptionBuilder.AppendLine($"Enlace: {selected.Url.AbsoluteUri}");
                txtSelectedMediaFileDetails.Text = descriptionBuilder.ToString();
            }
        }

        private void UrlLinkClicked(object sender, EventArgs e)
        {
            var senderText = (sender as LinkLabel).Text;
            Process.Start("explorer.exe", senderText);
        }

        private void RefreshDownloadListCombobox()
        {
            lbxContentToDownload.DataSource = null;
            lbxContentToDownload.Refresh();
            lbxContentToDownload.DataSource = _downloadList.ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToDownloadList_Click(object sender, EventArgs e)
        {
            if (cbSelectedMediaFiles.SelectedItem is not null)
            {
                var selected = cbSelectedMediaFiles.SelectedItem as MediaFile;
                if (!_downloadList.Any(fd => fd.File == selected))
                {
                    var fileToDownload = new FileToDownload
                    {
                        File = selected,
                        MediaContent = _selectedContent
                    };
                    _downloadList.Enqueue(fileToDownload);
                    RefreshDownloadListCombobox();
                    RefreshTotalDownloadSize();
                }
            }
        }

        private void lbxContentToDownload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContentToDownload.SelectedItem is not null)
            {
                var selected = lbxContentToDownload.SelectedItem as FileToDownload;
                SetFileToDownloadPreview(selected);
            }
        }

        private void RefreshTotalDownloadSize()
        {
            lbTotalDownloadSize.Text = $"Total a descargar: {_downloadList.Sum(f => f.File.FileSizeMB)} MB";
        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (!_downloading)
            {
                if (_frmDownloading is not null && !_frmDownloading.IsDisposed)
                {
                    _frmDownloading.Close();
                    _frmDownloading.Dispose();
                }
                if (_downloadList.Count > 0)
                {
                    SetStatusActionLabel("Iniciando descarga...");
                    var bfd = new FolderBrowserDialog
                    {
                        Description = "Seleccione la carpeta para guardar las descargas.",
                        UseDescriptionForTitle = true
                    };
                    if (bfd.ShowDialog() == DialogResult.OK)
                    {
                        _frmDownloading = new FrmDownloading();
                        _frmDownloading.RequestingCancel += (s, a) => _downloader.CancelFileDownload();
                        _frmDownloading.Show();
                        ShowStatusProgressBar();
                        btnRemoveFromDownloadList.Enabled = false;
                        btnStartDownload.Enabled = false;
                        StartNextDownload(bfd.SelectedPath);
                        _downloading = true;
                    }
                }
            }
        }

        private void StartNextDownload(string selectedPath)
        {
            if (_downloadList.Any())
            {
                var fileToDownload = _downloadList.Dequeue();
                RefreshDownloadListCombobox();
                _frmDownloading.SetDownload(fileToDownload, selectedPath);
                SetStatusActionLabel($"Descargando fichero: {fileToDownload.Name}");
                StartFileDownload(selectedPath, fileToDownload);
            }
            else
            {
                ResetDownloadState("Todos los ficheros han sido descargados");
            }
        }

        private void ResetDownloadState(string message)
        {
            _downloading = false;
            HideStatusProgressBar();
            btnRemoveFromDownloadList.Enabled = true;
            btnStartDownload.Enabled = true;
            _frmDownloading.Close();
            _frmDownloading.Dispose();
            SetStatusActionLabel(message);
        }

        private void StartFileDownload(string selectedFolder, FileToDownload fileToDownload)
        {
            var filename = Path.Combine(selectedFolder, fileToDownload.Name);

            _downloader.DownloadMediaFile(fileToDownload.File,
                                          filename,
                                          (toDownload, downloaded, percent) =>
                                          {
                                              _frmDownloading.SetCompletionPercent(percent, downloaded, toDownload);
                                              SetStatusProgressBarValue(percent);
                                          },
                                          (response) =>
                                          {
                                              switch (response)
                                              {
                                                  case "ok":
                                                      StartNextDownload(selectedFolder);
                                                      break;
                                                  case "cancelled":
                                                      MessageBox.Show("Cancelado!");
                                                      ResetDownloadState("Ha ocurrido un error en las descargas");
                                                      break;
                                                  default:
                                                      MessageBox.Show(response);
                                                      ResetDownloadState("Ha ocurrido un error en las descargas");
                                                      break;
                                              }
                                          });
        }
    }
}