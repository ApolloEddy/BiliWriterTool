
namespace BiliWriterTool
{
	partial class MainForm
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
			this.groupBox_ImgClass = new System.Windows.Forms.GroupBox();
			this.pictureBox_preview = new System.Windows.Forms.PictureBox();
			this.groupBox_ImgInfo = new System.Windows.Forms.GroupBox();
			this.lb_authorValue = new System.Windows.Forms.Label();
			this.lb_author = new System.Windows.Forms.Label();
			this.lb_imgSizeValue = new System.Windows.Forms.Label();
			this.lb_imgSize = new System.Windows.Forms.Label();
			this.lb_imgHeightValue = new System.Windows.Forms.Label();
			this.lb_imgHeight = new System.Windows.Forms.Label();
			this.lb_imgWidthValue = new System.Windows.Forms.Label();
			this.lb_imgWidth = new System.Windows.Forms.Label();
			this.lb_authorIDValue = new System.Windows.Forms.Label();
			this.lb_authorID = new System.Windows.Forms.Label();
			this.lb_artworkIDValue = new System.Windows.Forms.Label();
			this.lb_artworkID = new System.Windows.Forms.Label();
			this.lb_artworkValue = new System.Windows.Forms.Label();
			this.lb_artwork = new System.Windows.Forms.Label();
			this.button_after = new System.Windows.Forms.Button();
			this.button_saveOne = new System.Windows.Forms.Button();
			this.button_before = new System.Windows.Forms.Button();
			this.button_saveAll = new System.Windows.Forms.Button();
			this.button_search = new System.Windows.Forms.Button();
			this.textBox_path = new System.Windows.Forms.TextBox();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.lb_search = new System.Windows.Forms.Label();
			this.comboBox_source = new System.Windows.Forms.ComboBox();
			this.lb_path = new System.Windows.Forms.Label();
			this.lb_preview = new System.Windows.Forms.Label();
			this.lb_source = new System.Windows.Forms.Label();
			this.lb_imgIndex = new System.Windows.Forms.Label();
			this.ib_imgIndexValue = new System.Windows.Forms.Label();
			this.groupBox_ImgClass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
			this.groupBox_ImgInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_ImgClass
			// 
			this.groupBox_ImgClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.groupBox_ImgClass.Controls.Add(this.pictureBox_preview);
			this.groupBox_ImgClass.Controls.Add(this.groupBox_ImgInfo);
			this.groupBox_ImgClass.Controls.Add(this.button_after);
			this.groupBox_ImgClass.Controls.Add(this.button_saveOne);
			this.groupBox_ImgClass.Controls.Add(this.button_before);
			this.groupBox_ImgClass.Controls.Add(this.button_saveAll);
			this.groupBox_ImgClass.Controls.Add(this.button_search);
			this.groupBox_ImgClass.Controls.Add(this.textBox_path);
			this.groupBox_ImgClass.Controls.Add(this.textBox_search);
			this.groupBox_ImgClass.Controls.Add(this.lb_search);
			this.groupBox_ImgClass.Controls.Add(this.comboBox_source);
			this.groupBox_ImgClass.Controls.Add(this.lb_path);
			this.groupBox_ImgClass.Controls.Add(this.lb_preview);
			this.groupBox_ImgClass.Controls.Add(this.lb_source);
			this.groupBox_ImgClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox_ImgClass.Font = new System.Drawing.Font("STFangsong", 11.5F);
			this.groupBox_ImgClass.Location = new System.Drawing.Point(12, 12);
			this.groupBox_ImgClass.Name = "groupBox_ImgClass";
			this.groupBox_ImgClass.Size = new System.Drawing.Size(307, 505);
			this.groupBox_ImgClass.TabIndex = 0;
			this.groupBox_ImgClass.TabStop = false;
			this.groupBox_ImgClass.Text = "图片类";
			// 
			// pictureBox_preview
			// 
			this.pictureBox_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.pictureBox_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_preview.Location = new System.Drawing.Point(9, 152);
			this.pictureBox_preview.Name = "pictureBox_preview";
			this.pictureBox_preview.Size = new System.Drawing.Size(292, 164);
			this.pictureBox_preview.TabIndex = 7;
			this.pictureBox_preview.TabStop = false;
			// 
			// groupBox_ImgInfo
			// 
			this.groupBox_ImgInfo.Controls.Add(this.lb_authorValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_author);
			this.groupBox_ImgInfo.Controls.Add(this.ib_imgIndexValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgIndex);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgSizeValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgSize);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgHeightValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgHeight);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgWidthValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_imgWidth);
			this.groupBox_ImgInfo.Controls.Add(this.lb_authorIDValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_authorID);
			this.groupBox_ImgInfo.Controls.Add(this.lb_artworkIDValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_artworkID);
			this.groupBox_ImgInfo.Controls.Add(this.lb_artworkValue);
			this.groupBox_ImgInfo.Controls.Add(this.lb_artwork);
			this.groupBox_ImgInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox_ImgInfo.Font = new System.Drawing.Font("STFangsong", 10F);
			this.groupBox_ImgInfo.Location = new System.Drawing.Point(6, 322);
			this.groupBox_ImgInfo.Name = "groupBox_ImgInfo";
			this.groupBox_ImgInfo.Size = new System.Drawing.Size(295, 153);
			this.groupBox_ImgInfo.TabIndex = 6;
			this.groupBox_ImgInfo.TabStop = false;
			this.groupBox_ImgInfo.Text = "图片信息";
			// 
			// lb_authorValue
			// 
			this.lb_authorValue.AutoSize = true;
			this.lb_authorValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_authorValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_authorValue.Location = new System.Drawing.Point(69, 57);
			this.lb_authorValue.Name = "lb_authorValue";
			this.lb_authorValue.Size = new System.Drawing.Size(38, 13);
			this.lb_authorValue.TabIndex = 1;
			this.lb_authorValue.Text = "NULL";
			// 
			// lb_author
			// 
			this.lb_author.AutoSize = true;
			this.lb_author.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_author.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_author.Location = new System.Drawing.Point(7, 57);
			this.lb_author.Name = "lb_author";
			this.lb_author.Size = new System.Drawing.Size(55, 13);
			this.lb_author.TabIndex = 0;
			this.lb_author.Text = "作者名：";
			// 
			// lb_imgSizeValue
			// 
			this.lb_imgSizeValue.AutoSize = true;
			this.lb_imgSizeValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgSizeValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgSizeValue.Location = new System.Drawing.Point(69, 119);
			this.lb_imgSizeValue.Name = "lb_imgSizeValue";
			this.lb_imgSizeValue.Size = new System.Drawing.Size(38, 13);
			this.lb_imgSizeValue.TabIndex = 1;
			this.lb_imgSizeValue.Text = "NULL";
			// 
			// lb_imgSize
			// 
			this.lb_imgSize.AutoSize = true;
			this.lb_imgSize.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgSize.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgSize.Location = new System.Drawing.Point(7, 119);
			this.lb_imgSize.Name = "lb_imgSize";
			this.lb_imgSize.Size = new System.Drawing.Size(67, 13);
			this.lb_imgSize.TabIndex = 0;
			this.lb_imgSize.Text = "图像大小：";
			// 
			// lb_imgHeightValue
			// 
			this.lb_imgHeightValue.AutoSize = true;
			this.lb_imgHeightValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgHeightValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgHeightValue.Location = new System.Drawing.Point(69, 104);
			this.lb_imgHeightValue.Name = "lb_imgHeightValue";
			this.lb_imgHeightValue.Size = new System.Drawing.Size(38, 13);
			this.lb_imgHeightValue.TabIndex = 1;
			this.lb_imgHeightValue.Text = "NULL";
			// 
			// lb_imgHeight
			// 
			this.lb_imgHeight.AutoSize = true;
			this.lb_imgHeight.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgHeight.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgHeight.Location = new System.Drawing.Point(7, 104);
			this.lb_imgHeight.Name = "lb_imgHeight";
			this.lb_imgHeight.Size = new System.Drawing.Size(67, 13);
			this.lb_imgHeight.TabIndex = 0;
			this.lb_imgHeight.Text = "图像高度：";
			// 
			// lb_imgWidthValue
			// 
			this.lb_imgWidthValue.AutoSize = true;
			this.lb_imgWidthValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgWidthValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgWidthValue.Location = new System.Drawing.Point(69, 88);
			this.lb_imgWidthValue.Name = "lb_imgWidthValue";
			this.lb_imgWidthValue.Size = new System.Drawing.Size(38, 13);
			this.lb_imgWidthValue.TabIndex = 1;
			this.lb_imgWidthValue.Text = "NULL";
			// 
			// lb_imgWidth
			// 
			this.lb_imgWidth.AutoSize = true;
			this.lb_imgWidth.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgWidth.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgWidth.Location = new System.Drawing.Point(7, 88);
			this.lb_imgWidth.Name = "lb_imgWidth";
			this.lb_imgWidth.Size = new System.Drawing.Size(67, 13);
			this.lb_imgWidth.TabIndex = 0;
			this.lb_imgWidth.Text = "图像宽度：";
			// 
			// lb_authorIDValue
			// 
			this.lb_authorIDValue.AutoSize = true;
			this.lb_authorIDValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_authorIDValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_authorIDValue.Location = new System.Drawing.Point(69, 73);
			this.lb_authorIDValue.Name = "lb_authorIDValue";
			this.lb_authorIDValue.Size = new System.Drawing.Size(38, 13);
			this.lb_authorIDValue.TabIndex = 1;
			this.lb_authorIDValue.Text = "NULL";
			// 
			// lb_authorID
			// 
			this.lb_authorID.AutoSize = true;
			this.lb_authorID.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_authorID.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_authorID.Location = new System.Drawing.Point(7, 73);
			this.lb_authorID.Name = "lb_authorID";
			this.lb_authorID.Size = new System.Drawing.Size(56, 13);
			this.lb_authorID.TabIndex = 0;
			this.lb_authorID.Text = "作者ID：";
			// 
			// lb_artworkIDValue
			// 
			this.lb_artworkIDValue.AutoSize = true;
			this.lb_artworkIDValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_artworkIDValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_artworkIDValue.Location = new System.Drawing.Point(69, 41);
			this.lb_artworkIDValue.Name = "lb_artworkIDValue";
			this.lb_artworkIDValue.Size = new System.Drawing.Size(38, 13);
			this.lb_artworkIDValue.TabIndex = 1;
			this.lb_artworkIDValue.Text = "NULL";
			// 
			// lb_artworkID
			// 
			this.lb_artworkID.AutoSize = true;
			this.lb_artworkID.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_artworkID.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_artworkID.Location = new System.Drawing.Point(7, 41);
			this.lb_artworkID.Name = "lb_artworkID";
			this.lb_artworkID.Size = new System.Drawing.Size(56, 13);
			this.lb_artworkID.TabIndex = 0;
			this.lb_artworkID.Text = "作品ID：";
			// 
			// lb_artworkValue
			// 
			this.lb_artworkValue.AutoSize = true;
			this.lb_artworkValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_artworkValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_artworkValue.Location = new System.Drawing.Point(69, 25);
			this.lb_artworkValue.Name = "lb_artworkValue";
			this.lb_artworkValue.Size = new System.Drawing.Size(38, 13);
			this.lb_artworkValue.TabIndex = 1;
			this.lb_artworkValue.Text = "NULL";
			// 
			// lb_artwork
			// 
			this.lb_artwork.AutoSize = true;
			this.lb_artwork.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_artwork.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_artwork.Location = new System.Drawing.Point(7, 25);
			this.lb_artwork.Name = "lb_artwork";
			this.lb_artwork.Size = new System.Drawing.Size(55, 13);
			this.lb_artwork.TabIndex = 0;
			this.lb_artwork.Text = "作品名：";
			// 
			// button_after
			// 
			this.button_after.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button_after.Font = new System.Drawing.Font("STFangsong", 10F);
			this.button_after.Location = new System.Drawing.Point(217, 119);
			this.button_after.Name = "button_after";
			this.button_after.Size = new System.Drawing.Size(80, 23);
			this.button_after.TabIndex = 60;
			this.button_after.Text = "下一张";
			this.button_after.UseVisualStyleBackColor = false;
			this.button_after.Click += new System.EventHandler(this.button_after_Click);
			// 
			// button_saveOne
			// 
			this.button_saveOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button_saveOne.Font = new System.Drawing.Font("STFangsong", 10F);
			this.button_saveOne.Location = new System.Drawing.Point(217, 86);
			this.button_saveOne.Name = "button_saveOne";
			this.button_saveOne.Size = new System.Drawing.Size(80, 23);
			this.button_saveOne.TabIndex = 40;
			this.button_saveOne.Text = "保存单张";
			this.button_saveOne.UseVisualStyleBackColor = false;
			this.button_saveOne.Click += new System.EventHandler(this.button_saveOne_Click);
			// 
			// button_before
			// 
			this.button_before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button_before.Font = new System.Drawing.Font("STFangsong", 10F);
			this.button_before.Location = new System.Drawing.Point(114, 119);
			this.button_before.Name = "button_before";
			this.button_before.Size = new System.Drawing.Size(80, 23);
			this.button_before.TabIndex = 50;
			this.button_before.Text = "上一张";
			this.button_before.UseVisualStyleBackColor = false;
			this.button_before.Click += new System.EventHandler(this.button_before_Click);
			// 
			// button_saveAll
			// 
			this.button_saveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button_saveAll.Font = new System.Drawing.Font("STFangsong", 10F);
			this.button_saveAll.Location = new System.Drawing.Point(114, 86);
			this.button_saveAll.Name = "button_saveAll";
			this.button_saveAll.Size = new System.Drawing.Size(80, 23);
			this.button_saveAll.TabIndex = 30;
			this.button_saveAll.Text = "保存全部";
			this.button_saveAll.UseVisualStyleBackColor = false;
			this.button_saveAll.Click += new System.EventHandler(this.button_saveAll_Click);
			// 
			// button_search
			// 
			this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.button_search.Font = new System.Drawing.Font("STFangsong", 10F);
			this.button_search.Location = new System.Drawing.Point(9, 86);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(80, 23);
			this.button_search.TabIndex = 1;
			this.button_search.Text = "获取图片";
			this.button_search.UseVisualStyleBackColor = false;
			this.button_search.Click += new System.EventHandler(this.button_search_Click);
			// 
			// textBox_path
			// 
			this.textBox_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.textBox_path.Font = new System.Drawing.Font("STFangsong", 10F);
			this.textBox_path.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.textBox_path.Location = new System.Drawing.Point(95, 476);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.Size = new System.Drawing.Size(206, 25);
			this.textBox_path.TabIndex = 80;
			this.textBox_path.Text = "F:\\PixivImages\\Bilibili专栏\\P1\\";
			// 
			// textBox_search
			// 
			this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.textBox_search.Font = new System.Drawing.Font("STFangsong", 10F);
			this.textBox_search.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.textBox_search.Location = new System.Drawing.Point(61, 52);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(238, 25);
			this.textBox_search.TabIndex = 20;
			// 
			// lb_search
			// 
			this.lb_search.AutoSize = true;
			this.lb_search.Font = new System.Drawing.Font("STFangsong", 10F);
			this.lb_search.Location = new System.Drawing.Point(6, 55);
			this.lb_search.Name = "lb_search";
			this.lb_search.Size = new System.Drawing.Size(49, 16);
			this.lb_search.TabIndex = 3;
			this.lb_search.Text = "查询：";
			// 
			// comboBox_source
			// 
			this.comboBox_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.comboBox_source.Font = new System.Drawing.Font("STFangsong", 10F);
			this.comboBox_source.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.comboBox_source.FormattingEnabled = true;
			this.comboBox_source.Items.AddRange(new object[] {
            "P站 - Pixiv (https://www.pixiv.net)"});
			this.comboBox_source.Location = new System.Drawing.Point(61, 20);
			this.comboBox_source.Name = "comboBox_source";
			this.comboBox_source.Size = new System.Drawing.Size(238, 22);
			this.comboBox_source.TabIndex = 10;
			this.comboBox_source.Text = "P站 - Pixiv (https://www.pixiv.net)";
			// 
			// lb_path
			// 
			this.lb_path.AutoSize = true;
			this.lb_path.Font = new System.Drawing.Font("STFangsong", 11F);
			this.lb_path.Location = new System.Drawing.Point(6, 480);
			this.lb_path.Name = "lb_path";
			this.lb_path.Size = new System.Drawing.Size(83, 17);
			this.lb_path.TabIndex = 0;
			this.lb_path.Text = "存储路径：";
			// 
			// lb_preview
			// 
			this.lb_preview.AutoSize = true;
			this.lb_preview.Font = new System.Drawing.Font("STFangsong", 11F);
			this.lb_preview.Location = new System.Drawing.Point(6, 123);
			this.lb_preview.Name = "lb_preview";
			this.lb_preview.Size = new System.Drawing.Size(83, 17);
			this.lb_preview.TabIndex = 0;
			this.lb_preview.Text = "图片预览：";
			// 
			// lb_source
			// 
			this.lb_source.AutoSize = true;
			this.lb_source.Font = new System.Drawing.Font("STFangsong", 10F);
			this.lb_source.Location = new System.Drawing.Point(6, 23);
			this.lb_source.Name = "lb_source";
			this.lb_source.Size = new System.Drawing.Size(49, 16);
			this.lb_source.TabIndex = 0;
			this.lb_source.Text = "图源：";
			// 
			// lb_imgIndex
			// 
			this.lb_imgIndex.AutoSize = true;
			this.lb_imgIndex.Font = new System.Drawing.Font("STFangsong", 9F);
			this.lb_imgIndex.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lb_imgIndex.Location = new System.Drawing.Point(7, 135);
			this.lb_imgIndex.Name = "lb_imgIndex";
			this.lb_imgIndex.Size = new System.Drawing.Size(67, 13);
			this.lb_imgIndex.TabIndex = 0;
			this.lb_imgIndex.Text = "图像索引：";
			// 
			// ib_imgIndexValue
			// 
			this.ib_imgIndexValue.AutoSize = true;
			this.ib_imgIndexValue.Font = new System.Drawing.Font("STFangsong", 9F);
			this.ib_imgIndexValue.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.ib_imgIndexValue.Location = new System.Drawing.Point(69, 135);
			this.ib_imgIndexValue.Name = "ib_imgIndexValue";
			this.ib_imgIndexValue.Size = new System.Drawing.Size(38, 13);
			this.ib_imgIndexValue.TabIndex = 1;
			this.ib_imgIndexValue.Text = "NULL";
			// 
			// MainForm
			// 
			this.AcceptButton = this.button_search;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(331, 527);
			this.Controls.Add(this.groupBox_ImgClass);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "BiliWriteHelper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox_ImgClass.ResumeLayout(false);
			this.groupBox_ImgClass.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
			this.groupBox_ImgInfo.ResumeLayout(false);
			this.groupBox_ImgInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_ImgClass;
		private System.Windows.Forms.GroupBox groupBox_ImgInfo;
		private System.Windows.Forms.Label lb_authorValue;
		private System.Windows.Forms.Label lb_author;
		private System.Windows.Forms.Label lb_authorIDValue;
		private System.Windows.Forms.Label lb_authorID;
		private System.Windows.Forms.Label lb_artworkIDValue;
		private System.Windows.Forms.Label lb_artworkID;
		private System.Windows.Forms.Label lb_artworkValue;
		private System.Windows.Forms.Label lb_artwork;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Label lb_search;
		private System.Windows.Forms.ComboBox comboBox_source;
		private System.Windows.Forms.Label lb_source;
		private System.Windows.Forms.Label lb_imgSizeValue;
		private System.Windows.Forms.Label lb_imgSize;
		private System.Windows.Forms.Label lb_imgHeightValue;
		private System.Windows.Forms.Label lb_imgHeight;
		private System.Windows.Forms.Label lb_imgWidthValue;
		private System.Windows.Forms.Label lb_imgWidth;
		private System.Windows.Forms.PictureBox pictureBox_preview;
		private System.Windows.Forms.Label lb_preview;
		private System.Windows.Forms.Button button_after;
		private System.Windows.Forms.Button button_saveOne;
		private System.Windows.Forms.Button button_before;
		private System.Windows.Forms.Button button_saveAll;
		private System.Windows.Forms.TextBox textBox_path;
		private System.Windows.Forms.Label lb_path;
		private System.Windows.Forms.Label ib_imgIndexValue;
		private System.Windows.Forms.Label lb_imgIndex;
	}
}

