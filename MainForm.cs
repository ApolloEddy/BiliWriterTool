using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Aries;
using BiliWriterTool.DataContainer;

namespace BiliWriterTool
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Thread BackgroundThread;
		public List<ImageInfo> Images = new List<ImageInfo>();
		public int imgIndex = 0;


		private void SetError(string message)
		{ MessageBox.Show(message, "出错啦 >_< !!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		private void SetInfomation(string message)
		{ MessageBox.Show(message, "温馨提示 ₍ ᐢ.⌄.ᐢ ₎ ꜆˖.♡", MessageBoxButtons.OK, MessageBoxIcon.Information); }
		private void ShowImage(bool next = true, Button sender = null)
		{
			UpdateInfo update = UpdateInfos;
			if (sender is null)
			{ imgIndex = 0; pictureBox_preview.BackgroundImage = Images[imgIndex].Image; UpdateInfos(Images[imgIndex]); return; }
			if (Images.Count == 0)
			{ SetError("没有任何图片欸！"); return; }
			if (Images.Count == 1) 
			{ imgIndex = 0; pictureBox_preview.BackgroundImage = Images[imgIndex].Image; UpdateInfos(Images[imgIndex]); return; }
			if ((imgIndex  == 0) && (!next))
			{ SetInfomation("已经是第一张图片了噢!"); return; }
			if ((imgIndex + 1 >= Images.Count) && (next))
			{ SetInfomation("已经是最后一张图片了噢!"); return; }
			if (next) { imgIndex++; } else { imgIndex--; };
			pictureBox_preview .BackgroundImage = Images[imgIndex].Image;
			UpdateInfos(Images[imgIndex]);
		}
		private string getFilename(ImageInfo info)
		{
			string url = info.Url;
			return url.Substring(url.LastIndexOf('/') + 1);
		}
		private void UpdateInfos(ImageInfo info)
		{
			lb_artworkValue.Invoke(new ChangeLabelText(()   => { lb_artworkValue.Text = info.Artwork; }));
			lb_artworkIDValue.Invoke(new ChangeLabelText(() => { lb_artworkIDValue.Text = info.ArtworkID.ToString(); }));
			lb_authorValue.Invoke(new ChangeLabelText(()    => { lb_authorValue.Text = info.Author; }));
			lb_authorIDValue.Invoke(new ChangeLabelText(()  => { lb_authorIDValue.Text = info.AuthorID.ToString(); }));
			lb_imgWidthValue.Invoke(new ChangeLabelText(()  => { lb_imgWidthValue.Text = info.Width.ToString(); }));
			lb_imgHeightValue.Invoke(new ChangeLabelText(() => { lb_imgHeightValue.Text = info.Height.ToString(); }));
			lb_imgSizeValue.Invoke(new ChangeLabelText(()   => { lb_imgSizeValue.Text = info.Size.ToString(); }));
			ib_imgIndexValue.Invoke(new ChangeLabelText(()  => { ib_imgIndexValue.Text = $"{imgIndex + 1} / {Images.Count}"; }));
		}
		private delegate void UpdateInfo(ImageInfo info);
		private delegate void ChangeLabelText();

		private void MainForm_Load(object sender, EventArgs e)
		{
			groupBox_ImgClass.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
			groupBox_ImgInfo.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// 保存数据
			images imgsDataRoot = new images();
			imgsDataRoot.imageItem = new List<imagesImageItem>();
			foreach (var item in Images)
			{ imgsDataRoot.imageItem.Add(item.ToImagesImageItem()); }
			string fname = textBox_path.Text;
			if (!fname.EndsWith("/")) { fname += "/"; }
			fname += "data.xml";
			File.WriteAllText(fname, Interactor.Serialize(imgsDataRoot));

			// 关闭线程
			if (BackgroundThread == null)
			{ return; }
			if (!BackgroundThread.IsAlive)
			{ return; }
			BackgroundThread.Abort();
			BackgroundThread.DisableComObjectEagerCleanup();
			BackgroundThread = null;
		}
		private void button_search_Click(object sender, EventArgs e)
		{
			if (textBox_search.Text == "")
			{ SetError("没有输入搜索内容噢！"); return; }
			switch (comboBox_source.Text)
			{
				case "P站 - Pixiv (https://www.pixiv.net)":
					{
						BackgroundThread = new Thread(() =>
						{
						string idExpr = textBox_search.Text.ToLower();
						long id = 0;
						try { id = long.Parse(idExpr.Replace("p", "")); }
						catch (Exception ex) { SetError(ex.ToString()); return; }

						if (idExpr.StartsWith("p")) // 作品\图片
						{
							var imgs = PixivImageLoader.createImagesInfoByArtworkID(id);
							// MessageBox.Show($"Pcount:{imgs.imageItem.Count}\n" + Interactor.Serialize(imgs));
							foreach (var item in imgs.imageItem)
							{
									var info = ImageInfo.FromImagesImageItem(item);
									if (!Images.Contains(info))
									{ Images.Add(info); }
									else { info.Dispose(); }
								if ((imgs.imageItem.IndexOf(item) == 1) || (Images.Count <= 1))
								{ ShowImage(true); }
							}
						}
						else if (idExpr.StartsWith("a")) // 作者
						{
								
						}
						BackgroundThread.DisableComObjectEagerCleanup();
						BackgroundThread.Abort();
					});
					BackgroundThread.Start();
					break;
				}
			}
		}
		private void button_before_Click(object sender, EventArgs e)
		{ ShowImage(false, (Button)sender); }
		private void button_after_Click(object sender, EventArgs e)
		{ ShowImage(true,  (Button)sender); }
		private void button_saveOne_Click(object sender, EventArgs e)
		{
			string fname = textBox_path.Text;
			if (!fname.EndsWith("/")) { fname += "/"; }
			fname += getFilename(Images[imgIndex]); 
			Images[imgIndex].Image.Save(fname);
			SetInfomation($"成功保存图片到文件 \"{fname}\"!  (゜-゜)つロ~");
		}
		private void button_saveAll_Click(object sender, EventArgs e)
		{
			string fname = textBox_path.Text;
			if (!fname.EndsWith("/")) { fname += "/"; }
			foreach (var item in Images)
			{
				string fullpath = fname + getFilename(item);
				item.Image.Save(fullpath);
			}
			SetInfomation($"成功保存图片到路径 \"{fname}\"! 共保存{Images.Count}张图片！  (゜-゜)つロ~");
		}
	}

	public struct ImageInfo : IDisposable
	{
		public string Artwork { get; set; }
		public long ArtworkID { get; set; }
		public string Author { get; set; }
		public long AuthorID { get; set; }
		public Image Image { get; set; }
		public string Url { get; set; }
		public int Width { get { return Image.Width; } }
		public int Height { get { return Image.Height;} }
		public string Size
		{
			get
			{
				string result = string.Empty;
				long total = imgSize;
				double kb = (double)total / 1024;
				double mb = kb / 1024;
				if( mb < 1)
				{ result = string.Format("{0:0.00}", kb) + " KB"; }
				else
				{ result = string.Format("{0:0.00}", mb) + " MB"; }

				return result;
			}
		}
		private long imgSize { get; set; }
		public static ImageInfo FromImagesImageItem(imagesImageItem item)
		{
			ImageInfo result = new ImageInfo();
			result.Artwork = item.artwork.name;
			result.ArtworkID = item.artwork.id;
			result.Author = item.author.name;
			result.AuthorID = item.author.id;
			result.Url = item.artwork.url;
			var bytes = PixivImageLoader.getImageBytes(item.artwork.url);
			result.imgSize = (long)bytes.Length;
			result.Image = Image.FromStream(new MemoryStream(bytes));
			bytes = null;
			return result;
		}
		public imagesImageItem ToImagesImageItem()
		{
			imagesImageItem result = new imagesImageItem();
			result.artwork.name = Artwork;
			result.artwork.id = ArtworkID;
			result.artwork.url = Url;
			result.author.name = Author;
			result.author.id = AuthorID;
			return result;
		}

		public void Dispose()
		{
			((IDisposable)Image).Dispose();
		}
	}

	public static class PixivImageLoader
	{
		const string SampleAuthorInfoAPI = "https://www.pixiv.net/ajax/user/{id}?full=0&lang=zh";
		const string ImageAPI = "https://www.pixiv.net/ajax/illust/{id}/pages";
		const string PageAPI = "https://www.pixiv.net/artworks/{id}";

		public static WebProtocol createProtocol(string url, bool JsonOrImage = true)
		{
			WebProtocol result = new WebProtocol(url);
			result.Headers.Add("sec-fetch-dest", JsonOrImage ? "empty" : "document");
			result.Headers.Add("sec-fetch-mode", JsonOrImage ? "cors" : "navigate");
			result.Headers.Add("sec-fetch-site", JsonOrImage ? "same-origin" : "cross-site");
			result.Headers.Add("sec-fetch-user", "?1");
			result.Headers.Add("upgrade-insecure-requests", "1");
			result.Headers.Add("sec-ch-ua-mobile", "?0");
			// result.Headers.Add("x-userid", "65107909");
			result.Referer = "https://www.pixiv.net/";
			result.Timeout = 5000;

			return result;
		}
		public static string[] getAuthorInfo(long id)
		{
			/**
			  *	索引值：
			  *	0  ->  作者名
			  *	1  ->  作者ID
			*/
			string[] result = new string[2];
			string link = SampleAuthorInfoAPI.Replace("{id}", id.ToString());
			var web = createProtocol(link, true);
			web.Referer = link.Substring(0, link.LastIndexOf('?'));
			var page = web.contentDocument;
			TextParser tp = new TextParser(page);
			tp.extrim("\r", "\n", "\f");
			result[0] = tp.extractOne("\"name\":\"", "\"");
			result[1] = id.ToString();
			return result;
		}
		public static string[] getAuthorInfoByArtworkID(long id)
		{
			string page = createProtocol(SampleAuthorInfoAPI.Replace("{id}", id.ToString())).contentDocument;
			var tp = new TextParser(page);
			string aid = tp.extractOne("\"tags\":{\"authorId\":\"", "\",");
			return getAuthorInfo(long.Parse(aid));
		}
		public static string[] getArtworkInfo(long id)
		{
			string[] result = new string[2];

			return result;
		}
		public static string[] imageUrls(long id)
		{
			string link = ImageAPI.Replace("{id}", id.ToString());
			var web = createProtocol(link, true);
			web.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
			web.Referer = $"https://www.pixiv.net/artworks/{id}";
			web.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"92\", \" Not A;Brand\";v=99\", \"Microsoft Edge\";v=\"92\"");
			var htmlJson = web.contentDocument;
			var result = TextParser.extract(htmlJson, "original\":\"", "\"");
			
			return result.ToArray();
		}
		public static imagesImageItem createImagesItemInfoByArtworkID(long id)
		{
			imagesImageItem item = new imagesImageItem();
			string[] authorInfo = getAuthorInfo(id);
			item.author.name = authorInfo[0];
			item.author.id = long.Parse(authorInfo[0]);
			
			return item;
		}
		public static images createImagesInfoByArtworkID(long id)
		{
			images result = new images();
			var urls = imageUrls(id);
			var html = page(id);
			string[] authorInfo = new string[2];
			string[] artworkInfo = new string[2];
			// 作者信息
			TextParser tp = new TextParser(html);
			tp.extrim("\r", "\n", "\f");
			authorInfo[0] = tp.extractOne("\"name\":\"", "\"");
			authorInfo[1] = tp.extractOne("\"userId\":\"", "\"");
			// 作品信息
			artworkInfo[0] = tp.extractOne("<meta property=\"twitter:title\" content=\"", "\"");
			artworkInfo[1] = id.ToString();
			for (int i = 0; i < urls.Length; i++)
			{
				imagesImageItem image = new imagesImageItem();
				image.author.name = authorInfo[0];
				image.author.id = long.Parse(authorInfo[1]);
				image.artwork.name = artworkInfo[0];
				image.artwork.id = long.Parse(artworkInfo[1]);
				image.artwork.url = urls[i].Replace("\\/", "/");
				result.imageItem.Add(image);
			}

			return result;
		}
		public static string page(long id)
		{
			string link = PageAPI.Replace("{id}", id.ToString());
			var web = createProtocol(link);
			return web.contentDocument;

		}
		public static byte[] getImageBytes(string url)
		{ return createProtocol(url, false).contentBytes; }
		public static Image getImage(string url)
		{ 
			using (var ms = new MemoryStream(getImageBytes(url))) 
			{ return Image.FromStream(ms); } 
		}
	}
}
