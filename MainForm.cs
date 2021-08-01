using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
							string idExpr = textBox_path.Text.ToLower();
							try { long id = long.Parse(idExpr.Replace("p", "")); }
							catch (Exception ex) { SetError(ex.ToString()); }
							
							if (idExpr.StartsWith("p")) // 作品\图片
							{
								
							}
							else if (idExpr.StartsWith("a")) // 作者
							{

							}
						});
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

		public void Dispose()
		{
			((IDisposable)Image).Dispose();
		}
	}

	public static class PixivImageLoader
	{
		const string SampleAuthorInfoAPI = "https://www.pixiv.net/ajax/user/{id}?full=0&lang=zh";
		const string ImageAPI = "https://www.pixiv.net/ajax/illust/{id}/pages";

		public static WebProtocol createProtocol(string url, bool JsonOrImage = true)
		{
			WebProtocol result = new WebProtocol(url);
			result.Headers.Add("sec-fetch-dest", "empty");
			result.Headers.Add("sec-fetch-mode", "cors");
			result.Headers.Add("sec-fetch-site", JsonOrImage ? "same-origin" : "cross-site");
			result.Headers.Add("x-userid", "65107909");
			result.Referer = "https://www.pixiv.net/";

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
			result[0] = id.ToString();
			result[1] = tp.extractOne("\"name\":\"", "\"");
			return result;
		}
		public static string[] imageUrls(long id)
		{
			string link = ImageAPI.Replace("{id}", id.ToString());
			var web = createProtocol(link, true);
			var json = web.contentDocument;
			return TextParser.extract(json, "original\":\"", "\"").ToArray();
		}
		public static string[] getAuthorInfoByArtworkID(long id)
		{
			string page = createProtocol(SampleAuthorInfoAPI.Replace("{id}", id.ToString())).contentDocument;
			var tp = new TextParser(page);
			string aid = tp.extractOne("\"tags\":{\"authorId\":\"", "\",");
			return getAuthorInfo(long.Parse(aid));
		}
		public static imagesImageItem createImagesInfoByArtworkID(long id)
		{
			imagesImageItem item = new imagesImageItem();
			string[] authorInfo = getAuthorInfo(id);
			item.author.name = authorInfo[0];
			item.author.id = long.Parse(authorInfo[0]);
			return item;
		}
		public static byte[] getImageBytes(string url)
		{ return createProtocol(url, false).contentBytes; }
		public static Image getImage(string url)
		{ var ms = new MemoryStream(getImageBytes(url)); return Image.FromStream(ms); }
	}
}
