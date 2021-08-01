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
		public List<ImageInfo> images = new List<ImageInfo>();


		private void SetError(string message)
		{ MessageBox.Show(message, "出错啦 >_< !!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
		private void button_search_Click(object sender, EventArgs e)
		{
			
			switch (comboBox_source.Text)
			{
				case "P站 - Pixiv (https://www.pixiv.net)":
					{
						BackgroundThread = new Thread(() =>
						{
						string idExpr = textBox_search.Text.ToLower();
						long id = 0;
						try { id = long.Parse(idExpr.Replace("p", "")); }
						catch (Exception ex) { SetError(ex.ToString()); }

						if (idExpr.StartsWith("p")) // 作品\图片
						{
							var imgs = PixivImageLoader.createImagesInfoByArtworkID(id);
							// MessageBox.Show($"Pcount:{imgs.imageItem.Count}\n" + Interactor.Serialize(imgs));
							foreach (var item in imgs.imageItem)
							{
									var info = ImageInfo.FromImagesImageItem(item);
									if (!images.Contains(info))
									{ images.Add(info); }
									else { info.Dispose(); }
								if ((imgs.imageItem.IndexOf(item) == 1) && (images.Count > 1))
								{ pictureBox_preview.BackgroundImage = images[images.Count - 1].Image; }
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
				long total = Width * Height;
				double kb = (double)total / 1024;
				double mb = kb / 1024;
				if( mb > 1)
				{ result = string.Format("{0:2}", mb) + " KB"; }
				else
				{ result = string.Format("{0:2}", kb) + " MB"; }

				return result;
			}
		}
		public static ImageInfo FromImagesImageItem(imagesImageItem item)
		{
			ImageInfo result = new ImageInfo();
			result.Artwork = item.artwork.name;
			result.ArtworkID = item.artwork.id;
			result.Author = item.author.name;
			result.AuthorID = item.author.id;
			result.Image = PixivImageLoader.getImage(item.artwork.url);
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
				image.artwork.id = long.Parse(authorInfo[1]);
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
