
namespace Channel9Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnLoadContent = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlbAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.stpbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbChannelLang = new System.Windows.Forms.Label();
            this.lbChannelTotalMedia = new System.Windows.Forms.Label();
            this.lbChannelPubDate = new System.Windows.Forms.Label();
            this.lbChannelTitle = new System.Windows.Forms.Label();
            this.lbChannelUrl = new System.Windows.Forms.LinkLabel();
            this.lbChannelAuthor = new System.Windows.Forms.Label();
            this.lbChannelEmail = new System.Windows.Forms.Label();
            this.lbChannelCategory = new System.Windows.Forms.Label();
            this.pbChannelImage = new System.Windows.Forms.PictureBox();
            this.txtChannelSummary = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSelectedCreator = new System.Windows.Forms.Label();
            this.txtSelectedDescription = new System.Windows.Forms.RichTextBox();
            this.lbSelectedComment = new System.Windows.Forms.Label();
            this.lbSelectedAuthor = new System.Windows.Forms.Label();
            this.lbSelectedLink = new System.Windows.Forms.LinkLabel();
            this.lbSelectedGuid = new System.Windows.Forms.Label();
            this.lbSelectedTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSelectedMediaFiles = new System.Windows.Forms.ComboBox();
            this.btnAddToDownloadList = new System.Windows.Forms.Button();
            this.txtSelectedMediaFileDetails = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxContentMedia = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxContentToDownload = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveFromDownloadList = new System.Windows.Forms.Button();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.lbTotalDownloadSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descargar contenido de Channel 9 MSDN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Channel9Downloader.Properties.Resources.logo_channel_9;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL del contenido o canal:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(106, 92);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PlaceholderText = "Example: https://s.ch9.ms/Series/Beginners-Series-to-Blazor/rss";
            this.txtUrl.Size = new System.Drawing.Size(703, 27);
            this.txtUrl.TabIndex = 4;
            // 
            // btnLoadContent
            // 
            this.btnLoadContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContent.Location = new System.Drawing.Point(815, 92);
            this.btnLoadContent.Name = "btnLoadContent";
            this.btnLoadContent.Size = new System.Drawing.Size(116, 25);
            this.btnLoadContent.TabIndex = 7;
            this.btnLoadContent.Text = "Cargar contenido";
            this.btnLoadContent.UseVisualStyleBackColor = true;
            this.btnLoadContent.Click += new System.EventHandler(this.btnLoadContent_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Listado de medios";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 319);
            this.listBox1.TabIndex = 21;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(3, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(400, 319);
            this.listBox2.TabIndex = 21;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlbAction,
            this.stpbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlbAction
            // 
            this.stlbAction.Name = "stlbAction";
            this.stlbAction.Size = new System.Drawing.Size(386, 20);
            this.stlbAction.Text = "Escriba url y haga clic en Cargar contenido para empezar";
            // 
            // stpbProgress
            // 
            this.stpbProgress.Name = "stpbProgress";
            this.stpbProgress.Size = new System.Drawing.Size(100, 18);
            this.stpbProgress.Visible = false;
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Controls.Add(this.panel2, 0, 0);
            this.mainLayout.Controls.Add(this.panel3, 1, 1);
            this.mainLayout.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.mainLayout.Controls.Add(this.tableLayoutPanel9, 2, 1);
            this.mainLayout.Location = new System.Drawing.Point(12, 123);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(919, 475);
            this.mainLayout.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 129);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.lbChannelLang, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelTotalMedia, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelPubDate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelUrl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelAuthor, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelEmail, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbChannelCategory, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pbChannelImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtChannelSummary, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 98);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // lbChannelLang
            // 
            this.lbChannelLang.AutoSize = true;
            this.lbChannelLang.Location = new System.Drawing.Point(546, 19);
            this.lbChannelLang.Name = "lbChannelLang";
            this.lbChannelLang.Size = new System.Drawing.Size(67, 19);
            this.lbChannelLang.TabIndex = 27;
            this.lbChannelLang.Text = "Lenguaje";
            // 
            // lbChannelTotalMedia
            // 
            this.lbChannelTotalMedia.AutoSize = true;
            this.lbChannelTotalMedia.Location = new System.Drawing.Point(546, 38);
            this.lbChannelTotalMedia.Name = "lbChannelTotalMedia";
            this.lbChannelTotalMedia.Size = new System.Drawing.Size(114, 19);
            this.lbChannelTotalMedia.TabIndex = 28;
            this.lbChannelTotalMedia.Text = "Total de medios";
            // 
            // lbChannelPubDate
            // 
            this.lbChannelPubDate.AutoSize = true;
            this.lbChannelPubDate.Location = new System.Drawing.Point(546, 0);
            this.lbChannelPubDate.Name = "lbChannelPubDate";
            this.lbChannelPubDate.Size = new System.Drawing.Size(73, 19);
            this.lbChannelPubDate.TabIndex = 26;
            this.lbChannelPubDate.Text = "Publicado";
            // 
            // lbChannelTitle
            // 
            this.lbChannelTitle.AutoSize = true;
            this.lbChannelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbChannelTitle.Location = new System.Drawing.Point(184, 0);
            this.lbChannelTitle.Name = "lbChannelTitle";
            this.lbChannelTitle.Size = new System.Drawing.Size(66, 19);
            this.lbChannelTitle.TabIndex = 22;
            this.lbChannelTitle.Text = "Título";
            // 
            // lbChannelUrl
            // 
            this.lbChannelUrl.AutoSize = true;
            this.lbChannelUrl.Location = new System.Drawing.Point(184, 19);
            this.lbChannelUrl.Name = "lbChannelUrl";
            this.lbChannelUrl.Size = new System.Drawing.Size(50, 19);
            this.lbChannelUrl.TabIndex = 23;
            this.lbChannelUrl.TabStop = true;
            this.lbChannelUrl.Text = "Enlace";
            this.lbChannelUrl.Click += new System.EventHandler(this.UrlLinkClicked);
            // 
            // lbChannelAuthor
            // 
            this.lbChannelAuthor.AutoSize = true;
            this.lbChannelAuthor.Location = new System.Drawing.Point(184, 38);
            this.lbChannelAuthor.Name = "lbChannelAuthor";
            this.lbChannelAuthor.Size = new System.Drawing.Size(46, 19);
            this.lbChannelAuthor.TabIndex = 24;
            this.lbChannelAuthor.Text = "Autor";
            // 
            // lbChannelEmail
            // 
            this.lbChannelEmail.AutoSize = true;
            this.lbChannelEmail.Location = new System.Drawing.Point(184, 57);
            this.lbChannelEmail.Name = "lbChannelEmail";
            this.lbChannelEmail.Size = new System.Drawing.Size(42, 19);
            this.lbChannelEmail.TabIndex = 25;
            this.lbChannelEmail.Text = "Email";
            // 
            // lbChannelCategory
            // 
            this.lbChannelCategory.AutoSize = true;
            this.lbChannelCategory.Location = new System.Drawing.Point(184, 76);
            this.lbChannelCategory.Name = "lbChannelCategory";
            this.lbChannelCategory.Size = new System.Drawing.Size(73, 20);
            this.lbChannelCategory.TabIndex = 29;
            this.lbChannelCategory.Text = "Categoría";
            // 
            // pbChannelImage
            // 
            this.pbChannelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbChannelImage.Location = new System.Drawing.Point(3, 3);
            this.pbChannelImage.Name = "pbChannelImage";
            this.tableLayoutPanel2.SetRowSpan(this.pbChannelImage, 5);
            this.pbChannelImage.Size = new System.Drawing.Size(175, 92);
            this.pbChannelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChannelImage.TabIndex = 31;
            this.pbChannelImage.TabStop = false;
            // 
            // txtChannelSummary
            // 
            this.txtChannelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannelSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChannelSummary.Location = new System.Drawing.Point(546, 60);
            this.txtChannelSummary.Name = "txtChannelSummary";
            this.txtChannelSummary.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.txtChannelSummary, 2);
            this.txtChannelSummary.Size = new System.Drawing.Size(358, 35);
            this.txtChannelSummary.TabIndex = 30;
            this.txtChannelSummary.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Detalles del canal";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Location = new System.Drawing.Point(232, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 334);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(448, 331);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Detalles del medio seleccionado";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedCreator, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtSelectedDescription, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedComment, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedAuthor, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedLink, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedGuid, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.lbSelectedTitle, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(159, 29);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 299);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // lbSelectedCreator
            // 
            this.lbSelectedCreator.AutoSize = true;
            this.lbSelectedCreator.Location = new System.Drawing.Point(3, 185);
            this.lbSelectedCreator.Name = "lbSelectedCreator";
            this.lbSelectedCreator.Size = new System.Drawing.Size(63, 20);
            this.lbSelectedCreator.TabIndex = 36;
            this.lbSelectedCreator.Text = "Creador";
            // 
            // txtSelectedDescription
            // 
            this.txtSelectedDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedDescription.Location = new System.Drawing.Point(3, 40);
            this.txtSelectedDescription.Name = "txtSelectedDescription";
            this.txtSelectedDescription.ReadOnly = true;
            this.tableLayoutPanel5.SetRowSpan(this.txtSelectedDescription, 2);
            this.txtSelectedDescription.Size = new System.Drawing.Size(280, 68);
            this.txtSelectedDescription.TabIndex = 33;
            this.txtSelectedDescription.Text = "";
            // 
            // lbSelectedComment
            // 
            this.lbSelectedComment.AutoSize = true;
            this.lbSelectedComment.Location = new System.Drawing.Point(3, 111);
            this.lbSelectedComment.Name = "lbSelectedComment";
            this.lbSelectedComment.Size = new System.Drawing.Size(87, 20);
            this.lbSelectedComment.TabIndex = 34;
            this.lbSelectedComment.Text = "Comentario";
            // 
            // lbSelectedAuthor
            // 
            this.lbSelectedAuthor.AutoSize = true;
            this.lbSelectedAuthor.Location = new System.Drawing.Point(3, 148);
            this.lbSelectedAuthor.Name = "lbSelectedAuthor";
            this.lbSelectedAuthor.Size = new System.Drawing.Size(46, 20);
            this.lbSelectedAuthor.TabIndex = 35;
            this.lbSelectedAuthor.Text = "Autor";
            // 
            // lbSelectedLink
            // 
            this.lbSelectedLink.AutoSize = true;
            this.lbSelectedLink.Location = new System.Drawing.Point(3, 222);
            this.lbSelectedLink.Name = "lbSelectedLink";
            this.lbSelectedLink.Size = new System.Drawing.Size(50, 20);
            this.lbSelectedLink.TabIndex = 37;
            this.lbSelectedLink.TabStop = true;
            this.lbSelectedLink.Text = "Enlace";
            this.lbSelectedLink.Click += new System.EventHandler(this.UrlLinkClicked);
            // 
            // lbSelectedGuid
            // 
            this.lbSelectedGuid.AutoSize = true;
            this.lbSelectedGuid.Location = new System.Drawing.Point(3, 259);
            this.lbSelectedGuid.Name = "lbSelectedGuid";
            this.lbSelectedGuid.Size = new System.Drawing.Size(40, 20);
            this.lbSelectedGuid.TabIndex = 38;
            this.lbSelectedGuid.Text = "Guid";
            // 
            // lbSelectedTitle
            // 
            this.lbSelectedTitle.AutoSize = true;
            this.lbSelectedTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelectedTitle.Location = new System.Drawing.Point(3, 0);
            this.lbSelectedTitle.Name = "lbSelectedTitle";
            this.lbSelectedTitle.Size = new System.Drawing.Size(66, 27);
            this.lbSelectedTitle.TabIndex = 23;
            this.lbSelectedTitle.Text = "Título";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.pbThumbnail, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cbSelectedMediaFiles, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnAddToDownloadList, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.txtSelectedMediaFileDetails, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.02227F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.302227F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60445F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.20891F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.862142F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(150, 299);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbThumbnail.Location = new System.Drawing.Point(3, 3);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(144, 152);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumbnail.TabIndex = 21;
            this.pbThumbnail.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Archivos";
            // 
            // cbSelectedMediaFiles
            // 
            this.cbSelectedMediaFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectedMediaFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectedMediaFiles.FormattingEnabled = true;
            this.cbSelectedMediaFiles.Location = new System.Drawing.Point(3, 176);
            this.cbSelectedMediaFiles.Name = "cbSelectedMediaFiles";
            this.cbSelectedMediaFiles.Size = new System.Drawing.Size(144, 28);
            this.cbSelectedMediaFiles.TabIndex = 23;
            this.cbSelectedMediaFiles.SelectedIndexChanged += new System.EventHandler(this.cbSelectedMediaFiles_SelectedIndexChanged);
            // 
            // btnAddToDownloadList
            // 
            this.btnAddToDownloadList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToDownloadList.Location = new System.Drawing.Point(3, 270);
            this.btnAddToDownloadList.Name = "btnAddToDownloadList";
            this.btnAddToDownloadList.Size = new System.Drawing.Size(144, 26);
            this.btnAddToDownloadList.TabIndex = 24;
            this.btnAddToDownloadList.Text = "Agregar a descargas";
            this.btnAddToDownloadList.UseVisualStyleBackColor = true;
            this.btnAddToDownloadList.Click += new System.EventHandler(this.btnAddToDownloadList_Click);
            // 
            // txtSelectedMediaFileDetails
            // 
            this.txtSelectedMediaFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedMediaFileDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedMediaFileDetails.Location = new System.Drawing.Point(3, 207);
            this.txtSelectedMediaFileDetails.Name = "txtSelectedMediaFileDetails";
            this.txtSelectedMediaFileDetails.ReadOnly = true;
            this.txtSelectedMediaFileDetails.Size = new System.Drawing.Size(144, 57);
            this.txtSelectedMediaFileDetails.TabIndex = 25;
            this.txtSelectedMediaFileDetails.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbxContentMedia, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.76699F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.37864F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(223, 334);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Listado de medios";
            // 
            // lbxContentMedia
            // 
            this.lbxContentMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxContentMedia.FormattingEnabled = true;
            this.lbxContentMedia.ItemHeight = 20;
            this.lbxContentMedia.Location = new System.Drawing.Point(3, 30);
            this.lbxContentMedia.Name = "lbxContentMedia";
            this.lbxContentMedia.Size = new System.Drawing.Size(217, 284);
            this.lbxContentMedia.TabIndex = 21;
            this.lbxContentMedia.SelectedIndexChanged += new System.EventHandler(this.lbxContentMedia_SelectedIndexChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lbxContentToDownload, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.lbTotalDownloadSize, 0, 2);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(691, 138);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.795853F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.47468F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.179985F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54948F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(225, 334);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Listado a descargar";
            // 
            // lbxContentToDownload
            // 
            this.lbxContentToDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxContentToDownload.FormattingEnabled = true;
            this.lbxContentToDownload.ItemHeight = 20;
            this.lbxContentToDownload.Location = new System.Drawing.Point(3, 35);
            this.lbxContentToDownload.Name = "lbxContentToDownload";
            this.lbxContentToDownload.Size = new System.Drawing.Size(219, 224);
            this.lbxContentToDownload.TabIndex = 22;
            this.lbxContentToDownload.SelectedIndexChanged += new System.EventHandler(this.lbxContentToDownload_SelectedIndexChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel10.Controls.Add(this.btnRemoveFromDownloadList, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnStartDownload, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(219, 31);
            this.tableLayoutPanel10.TabIndex = 23;
            // 
            // btnRemoveFromDownloadList
            // 
            this.btnRemoveFromDownloadList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFromDownloadList.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveFromDownloadList.Name = "btnRemoveFromDownloadList";
            this.btnRemoveFromDownloadList.Size = new System.Drawing.Size(30, 25);
            this.btnRemoveFromDownloadList.TabIndex = 0;
            this.btnRemoveFromDownloadList.Text = "E";
            this.btnRemoveFromDownloadList.UseVisualStyleBackColor = true;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDownload.Font = new System.Drawing.Font("Segoe UI Variable Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartDownload.Location = new System.Drawing.Point(39, 3);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(177, 25);
            this.btnStartDownload.TabIndex = 1;
            this.btnStartDownload.Text = "Inciar descargas...";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // lbTotalDownloadSize
            // 
            this.lbTotalDownloadSize.AutoSize = true;
            this.lbTotalDownloadSize.Location = new System.Drawing.Point(3, 274);
            this.lbTotalDownloadSize.Name = "lbTotalDownloadSize";
            this.lbTotalDownloadSize.Size = new System.Drawing.Size(123, 20);
            this.lbTotalDownloadSize.TabIndex = 24;
            this.lbTotalDownloadSize.Text = "Total a descargar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 623);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.btnLoadContent);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(866, 637);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channel 9 MSDN Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLoadContent;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbChannelTitle;
        private System.Windows.Forms.Label lbChannelPubDate;
        private System.Windows.Forms.LinkLabel lbChannelUrl;
        private System.Windows.Forms.Label lbChannelEmail;
        private System.Windows.Forms.Label lbChannelAuthor;
        private System.Windows.Forms.Label lbChannelLang;
        private System.Windows.Forms.Label lbChannelCategory;
        private System.Windows.Forms.Label lbChannelTotalMedia;
        private System.Windows.Forms.RichTextBox txtChannelSummary;
        private System.Windows.Forms.PictureBox pbChannelImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbSelectedTitle;
        private System.Windows.Forms.RichTextBox txtSelectedDescription;
        private System.Windows.Forms.Label lbSelectedComment;
        private System.Windows.Forms.Label lbSelectedCreator;
        private System.Windows.Forms.Label lbSelectedAuthor;
        private System.Windows.Forms.LinkLabel lbSelectedLink;
        private System.Windows.Forms.Label lbSelectedGuid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSelectedMediaFiles;
        private System.Windows.Forms.Button btnAddToDownloadList;
        private System.Windows.Forms.ListBox lbxContentMedia;
        private System.Windows.Forms.RichTextBox txtSelectedMediaFileDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlbAction;
        private System.Windows.Forms.ToolStripProgressBar stpbProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ListBox lbxContentToDownload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnRemoveFromDownloadList;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.Label lbTotalDownloadSize;
    }
}

