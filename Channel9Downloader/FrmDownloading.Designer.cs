
namespace Channel9Downloader
{
    partial class FrmDownloading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbUrl = new System.Windows.Forms.LinkLabel();
            this.lbFilename = new System.Windows.Forms.Label();
            this.btnRequestCancel = new System.Windows.Forms.Button();
            this.lbProgress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Channel9Downloader.Properties.Resources.logo_channel_9;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(72, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(81, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(325, 43);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Descargando archivo";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(81, 136);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(484, 25);
            this.pbProgress.TabIndex = 5;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoEllipsis = true;
            this.lbUrl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbUrl, 2);
            this.lbUrl.Location = new System.Drawing.Point(81, 83);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(109, 16);
            this.lbUrl.TabIndex = 6;
            this.lbUrl.TabStop = true;
            this.lbUrl.Text = "Ruta de la descarga";
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbFilename, 2);
            this.lbFilename.Location = new System.Drawing.Point(81, 108);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(90, 16);
            this.lbFilename.TabIndex = 7;
            this.lbFilename.Text = "Ruta del fichero";
            // 
            // btnRequestCancel
            // 
            this.btnRequestCancel.Location = new System.Drawing.Point(571, 136);
            this.btnRequestCancel.Name = "btnRequestCancel";
            this.btnRequestCancel.Size = new System.Drawing.Size(68, 25);
            this.btnRequestCancel.TabIndex = 8;
            this.btnRequestCancel.Text = "&Cancelar";
            this.btnRequestCancel.UseVisualStyleBackColor = true;
            this.btnRequestCancel.Click += new System.EventHandler(this.btnRequestCancel_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(81, 166);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(115, 16);
            this.lbProgress.TabIndex = 9;
            this.lbProgress.Text = "Iniciando descarga...";
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.33588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.45038F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRequestCancel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbProgress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbProgress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbFilename, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.45181F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.03555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.03555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.44156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.03555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 193);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // FrmDownloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 222);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDownloading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDownloading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.LinkLabel lbUrl;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.Button btnRequestCancel;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}