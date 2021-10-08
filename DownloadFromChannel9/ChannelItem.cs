namespace DownloadFromChannel9
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class rss
    {
        private rssChannel channelField;

        private decimal versionField;

        /// <remarks/>
        public rssChannel channel
        {
            get => channelField;
            set => channelField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal version
        {
            get => versionField;
            set => versionField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class rssChannel
    {

        private string titleField;

        private link linkField;

        private string summaryField;

        private string authorField;

        private string author1Field;

        private string emailField;

        private owner ownerField;

        private object subtitleField;

        private bool explicitField;

        private rssChannelImage imageField;

        private image image1Field;

        private category categoryField;

        private string descriptionField;

        private string link1Field;

        private string languageField;

        private string pubDateField;

        private string lastBuildDateField;

        private string generatorField;

        private byte totalResultsField;

        private byte pageCountField;

        private byte pageSizeField;

        private rssChannelItem[] itemField;

        /// <remarks/>
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.w3.org/2005/Atom")]
        public link link
        {
            get => linkField;
            set => linkField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string summary
        {
            get => summaryField;
            set => summaryField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.google.com/schemas/play-podcasts/1.0")]
        public string author
        {
            get => authorField;
            set => authorField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("author", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string author1
        {
            get => author1Field;
            set => author1Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.google.com/schemas/play-podcasts/1.0")]
        public string email
        {
            get => emailField;
            set => emailField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public owner owner
        {
            get => ownerField;
            set => ownerField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public object subtitle
        {
            get => subtitleField;
            set => subtitleField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public bool @explicit
        {
            get => explicitField;
            set => explicitField = value;
        }

        /// <remarks/>
        public rssChannelImage image
        {
            get => imageField;
            set => imageField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("image", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public image image1
        {
            get => image1Field;
            set => image1Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public category category
        {
            get => categoryField;
            set => categoryField = value;
        }

        /// <remarks/>
        public string description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("link")]
        public string link1
        {
            get => link1Field;
            set => link1Field = value;
        }

        /// <remarks/>
        public string language
        {
            get => languageField;
            set => languageField = value;
        }

        /// <remarks/>
        public string pubDate
        {
            get => pubDateField;
            set => pubDateField = value;
        }

        /// <remarks/>
        public string lastBuildDate
        {
            get => lastBuildDateField;
            set => lastBuildDateField = value;
        }

        /// <remarks/>
        public string generator
        {
            get => generatorField;
            set => generatorField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://channel9.msdn.com")]
        public byte totalResults
        {
            get => totalResultsField;
            set => totalResultsField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://channel9.msdn.com")]
        public byte pageCount
        {
            get => pageCountField;
            set => pageCountField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://channel9.msdn.com")]
        public byte pageSize
        {
            get => pageSizeField;
            set => pageSizeField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("item")]
        public rssChannelItem[] item
        {
            get => itemField;
            set => itemField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
    public partial class link
    {

        private string relField;

        private string typeField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string rel
        {
            get => relField;
            set => relField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string href
        {
            get => hrefField;
            set => hrefField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class owner
    {

        private string emailField;

        /// <remarks/>
        public string email
        {
            get => emailField;
            set => emailField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class rssChannelImage
    {

        private string urlField;

        private string titleField;

        private string linkField;

        /// <remarks/>
        public string url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks/>
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks/>
        public string link
        {
            get => linkField;
            set => linkField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class image
    {

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string href
        {
            get => hrefField;
            set => hrefField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
    public partial class category
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string text
        {
            get => textField;
            set => textField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class rssChannelItem
    {
        private string titleField;

        private string descriptionField;

        private string commentsField;

        private string summaryField;

        private ushort durationField;

        private string linkField;

        private string pubDateField;

        private rssChannelItemGuid guidField;

        private thumbnail[] thumbnailField;

        private groupContent[] groupField;

        private rssChannelItemEnclosure enclosureField;

        private string creatorField;

        private string authorField;

        private byte comments1Field;

        private string commentRssField;

        private string[] categoryField;

        /// <remarks/>
        public string title
        {
            get => titleField;
            set => titleField = value;
        }

        /// <remarks/>
        public string description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks/>
        public string comments
        {
            get => commentsField;
            set => commentsField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string summary
        {
            get => summaryField;
            set => summaryField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public ushort duration
        {
            get => durationField;
            set => durationField = value;
        }

        /// <remarks/>
        public string link
        {
            get => linkField;
            set => linkField = value;
        }

        /// <remarks/>
        public string pubDate
        {
            get => pubDateField;
            set => pubDateField = value;
        }

        /// <remarks/>
        public rssChannelItemGuid guid
        {
            get => guidField;
            set => guidField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("thumbnail", Namespace = "http://search.yahoo.com/mrss/")]
        public thumbnail[] thumbnail
        {
            get => thumbnailField;
            set => thumbnailField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Namespace = "http://search.yahoo.com/mrss/")]
        [System.Xml.Serialization.XmlArrayItem("content", IsNullable = false)]
        public groupContent[] group
        {
            get => groupField;
            set => groupField = value;
        }

        /// <remarks/>
        public rssChannelItemEnclosure enclosure
        {
            get => enclosureField;
            set => enclosureField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://purl.org/dc/elements/1.1/")]
        public string creator
        {
            get => creatorField;
            set => creatorField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string author
        {
            get => authorField;
            set => authorField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("comments", Namespace = "http://purl.org/rss/1.0/modules/slash/")]
        public byte comments1
        {
            get => comments1Field;
            set => comments1Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Namespace = "http://wellformedweb.org/CommentAPI/")]
        public string commentRss
        {
            get => commentRssField;
            set => commentRssField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("category")]
        public string[] category
        {
            get => categoryField;
            set => categoryField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class rssChannelItemGuid
    {

        private bool isPermaLinkField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public bool isPermaLink
        {
            get => isPermaLinkField;
            set => isPermaLinkField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
    public partial class thumbnail
    {

        private string urlField;

        private ushort heightField;

        private ushort widthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort height
        {
            get => heightField;
            set => heightField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort width
        {
            get => widthField;
            set => widthField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    public partial class groupContent
    {

        private string urlField;

        private string expressionField;

        private ushort durationField;

        private uint fileSizeField;

        private string typeField;

        private string mediumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string expression
        {
            get => expressionField;
            set => expressionField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort duration
        {
            get => durationField;
            set => durationField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public uint fileSize
        {
            get => fileSizeField;
            set => fileSizeField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string medium
        {
            get => mediumField;
            set => mediumField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class rssChannelItemEnclosure
    {

        private string urlField;

        private uint lengthField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string url
        {
            get => urlField;
            set => urlField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public uint length
        {
            get => lengthField;
            set => lengthField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get => typeField;
            set => typeField = value;
        }
    }

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
    public partial class group
    {

        private groupContent[] contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("content")]
        public groupContent[] content
        {
            get => contentField;
            set => contentField = value;
        }
    }


}