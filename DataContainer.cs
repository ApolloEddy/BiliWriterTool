using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BiliWriterTool.DataContainer
{
	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class images
	{

		private List<imagesImageItem> imageItemField = new List<imagesImageItem>();

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("imageItem")]
		public List<imagesImageItem> imageItem
		{
			get
			{
				return this.imageItemField;
			}
			set
			{
				this.imageItemField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class imagesImageItem
	{

		private imagesImageItemArtwork artworkField = new imagesImageItemArtwork();

		private imagesImageItemAuthor authorField = new imagesImageItemAuthor();

		private string localpathField;

		/// <remarks/>
		public imagesImageItemArtwork artwork
		{
			get
			{
				return this.artworkField;
			}
			set
			{
				this.artworkField = value;
			}
		}

		/// <remarks/>
		public imagesImageItemAuthor author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		/// <remarks/>
		public string localpath
		{
			get
			{
				return this.localpathField;
			}
			set
			{
				this.localpathField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class imagesImageItemArtwork
	{

		private string nameField;

		private long idField;

		private string urlField;

		/// <remarks/>
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public long id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class imagesImageItemAuthor
	{

		private string nameField;

		private long idField;

		/// <remarks/>
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public long id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
	}





	public abstract class Interactor
	{
		public static images Deserialize(string xmlPath)
		{
			if (!File.Exists(xmlPath))
			{ return null; }
			images result = new images();
			using (StringReader reader = new StringReader(xmlPath))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(images));
				MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
				result = (images)serializer.Deserialize(ms);
			}
			return result;
		}
		public static string Serialize(images images)
		{
			string result = string.Empty;
			using (MemoryStream ms = new MemoryStream())
			{
				XmlSerializer serializer = new XmlSerializer(typeof(images));
				serializer.Serialize(ms, images);
				var bytes = ms.ToArray();
				result = Encoding.UTF8.GetString(bytes);
			}

			return result;
		}
	}
}
