using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "44e92a5e93598a18")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Blog Post</summary>
	[PublishedContentModel("BlogPost")]
	public partial class BlogPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Introduction
		///</summary>
		[ImplementPropertyType("introduction")]
		public string Introduction
		{
			get { return this.GetPropertyValue<string>("introduction"); }
		}
	}

	/// <summary>Blog Post Repository</summary>
	[PublishedContentModel("BlogPostRepository")]
	public partial class BlogPostRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPostRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPostRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPostRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("Home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Site Description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public object SiteLogo
		{
			get { return this.GetPropertyValue("siteLogo"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}
	}

	/// <summary>Landing Page</summary>
	[PublishedContentModel("LandingPage")]
	public partial class LandingPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "LandingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LandingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("TextPage")]
	public partial class TextPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "TextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}
	}

	/// <summary>Google Analytics Tracking</summary>
	[PublishedContentModel("googleAnalyticsEventRoot")]
	public partial class GoogleAnalyticsEventRoot : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "googleAnalyticsEventRoot";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GoogleAnalyticsEventRoot(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GoogleAnalyticsEventRoot, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Disable GA Events: Settings this flag will disable all events on all pages.
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_DisableEvents")]
		public bool GoogleAnalyticsEvent_DisableEvents
		{
			get { return this.GetPropertyValue<bool>("googleAnalyticsEvent_DisableEvents"); }
		}

		///<summary>
		/// Google Analytics Key: Enter your unique GA property id here to be used on the page
		///</summary>
		[ImplementPropertyType("googleAnalyticsKey")]
		public string GoogleAnalyticsKey
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsKey"); }
		}
	}

	/// <summary>Advanced Event</summary>
	[PublishedContentModel("googleAnalyticsEventItem")]
	public partial class GoogleAnalyticsEventItem : PublishedContentModel, IGoogleAnalyticsEventBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "googleAnalyticsEventItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GoogleAnalyticsEventItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GoogleAnalyticsEventItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Action: The action type that you are listening for on the element. Example: The "click" action will fire when an element is clicked
		///</summary>
		[ImplementPropertyType("action")]
		public object Action
		{
			get { return this.GetPropertyValue("action"); }
		}

		///<summary>
		/// Label: The label to use for the GA event.{br /}{br /} Please note that this is templatable. Simple enter one of the following placeholders and it will be replaced by the appropriate value when the vent takes place: {br /}{br /}PageUrl: {PAGE_URL}, PageRelativeUrl: {PAGE_RELATIVE_URL}, TagName: {TAG_NAME}, ID: {ID} , Class: {CLASS}, Value: {VALUE}, Src: {SRC}, LinkUrl: {LINK_URL}, LinkRelativeUrl: {LINK_RELATIVE_URL}, Alt: {ALT}, Title: {TITLE}, InnerHTML: {INNER_HTML}. {br /}{br /} Still confused? {a href="https://codelaborators-network.github.io/Google-Analytics-Events-for-Umbraco/" target="_blank" title="Opens in new tab"}Check out the documentation for more detailed guides{/a}
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_Label")]
		public string GoogleAnalyticsEvent_Label
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsEvent_Label"); }
		}

		///<summary>
		/// Category: The category the event should be classified in the Google Analytics dashboard
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_Category")]
		public string GoogleAnalyticsEvent_Category
		{
			get { return GoogleAnalyticsEventBase.GetGoogleAnalyticsEvent_Category(this); }
		}

		///<summary>
		/// CSS Selector: The CSS selector that will be used to attach the GA event to the element. Example: ".someClass", "#some-id", "h1"{br /}{br /} Don't know CSS? {a href="https://codelaborators-network.github.io/Google-Analytics-Events-for-Umbraco/" target="_blank" title="Opens in new tab"}Check out the documentation for more examples{/a}
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_CssSelector")]
		public string GoogleAnalyticsEvent_CssSelector
		{
			get { return GoogleAnalyticsEventBase.GetGoogleAnalyticsEvent_CssSelector(this); }
		}
	}

	/// <summary>Standard Event</summary>
	[PublishedContentModel("googleAnalyticsStandardEvent")]
	public partial class GoogleAnalyticsStandardEvent : PublishedContentModel, IGoogleAnalyticsEventBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "googleAnalyticsStandardEvent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GoogleAnalyticsStandardEvent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GoogleAnalyticsStandardEvent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Action: The action type that you are listening for on the element. Example: The "click" action will fire when an element is clicked
		///</summary>
		[ImplementPropertyType("action")]
		public object Action
		{
			get { return this.GetPropertyValue("action"); }
		}

		///<summary>
		/// Label: Choose which information you would like to appear in the label in Google Analytics. If you want more control of this, create a Google Analytics Advanced Event instead.
		///</summary>
		[ImplementPropertyType("label")]
		public object Label
		{
			get { return this.GetPropertyValue("label"); }
		}

		///<summary>
		/// Category: The category the event should be classified in the Google Analytics dashboard
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_Category")]
		public string GoogleAnalyticsEvent_Category
		{
			get { return GoogleAnalyticsEventBase.GetGoogleAnalyticsEvent_Category(this); }
		}

		///<summary>
		/// CSS Selector: The CSS selector that will be used to attach the GA event to the element. Example: ".someClass", "#some-id", "h1"{br /}{br /} Don't know CSS? {a href="https://codelaborators-network.github.io/Google-Analytics-Events-for-Umbraco/" target="_blank" title="Opens in new tab"}Check out the documentation for more examples{/a}
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_CssSelector")]
		public string GoogleAnalyticsEvent_CssSelector
		{
			get { return GoogleAnalyticsEventBase.GetGoogleAnalyticsEvent_CssSelector(this); }
		}
	}

	// Mixin content Type 1112 with alias "googleAnalyticsEventBase"
	/// <summary>Event Base</summary>
	public partial interface IGoogleAnalyticsEventBase : IPublishedContent
	{
		/// <summary>Category</summary>
		string GoogleAnalyticsEvent_Category { get; }

		/// <summary>CSS Selector</summary>
		string GoogleAnalyticsEvent_CssSelector { get; }
	}

	/// <summary>Event Base</summary>
	[PublishedContentModel("googleAnalyticsEventBase")]
	public partial class GoogleAnalyticsEventBase : PublishedContentModel, IGoogleAnalyticsEventBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "googleAnalyticsEventBase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GoogleAnalyticsEventBase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GoogleAnalyticsEventBase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Category: The category the event should be classified in the Google Analytics dashboard
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_Category")]
		public string GoogleAnalyticsEvent_Category
		{
			get { return GetGoogleAnalyticsEvent_Category(this); }
		}

		/// <summary>Static getter for Category</summary>
		public static string GetGoogleAnalyticsEvent_Category(IGoogleAnalyticsEventBase that) { return that.GetPropertyValue<string>("googleAnalyticsEvent_Category"); }

		///<summary>
		/// CSS Selector: The CSS selector that will be used to attach the GA event to the element. Example: ".someClass", "#some-id", "h1"{br /}{br /} Don't know CSS? {a href="https://codelaborators-network.github.io/Google-Analytics-Events-for-Umbraco/" target="_blank" title="Opens in new tab"}Check out the documentation for more examples{/a}
		///</summary>
		[ImplementPropertyType("googleAnalyticsEvent_CssSelector")]
		public string GoogleAnalyticsEvent_CssSelector
		{
			get { return GetGoogleAnalyticsEvent_CssSelector(this); }
		}

		/// <summary>Static getter for CSS Selector</summary>
		public static string GetGoogleAnalyticsEvent_CssSelector(IGoogleAnalyticsEventBase that) { return that.GetPropertyValue<string>("googleAnalyticsEvent_CssSelector"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
