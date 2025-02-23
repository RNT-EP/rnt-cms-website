using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core.Models.PublishedContent;


namespace RNTWEBSITE.Extensions
{
    public static class PublishedContentExtensions
    {
    public static HomePage? GetHomePage(this IPublishedContent publishedContent)
    {
        return publishedContent.AncestorOrSelf<HomePage>();
    }

    public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
    {
        var homePage = GetHomePage(publishedContent);
        return homePage?.FirstChild<SiteSettings>();
    }
    public static string? GetSiteName(this IPublishedContent publishedContent)
    {
        var homePage = publishedContent.GetHomePage();
        if (homePage == null) return null;
        var siteSettings = homePage.GetSiteSettings();
        if (siteSettings == null) return null;
        return siteSettings?.SiteName ?? null;
    }

    public static string? GetSiteIconUrl(this IPublishedContent publishedContent)
    {
        var siteSettings = publishedContent.GetSiteSettings();
        var siteIcon = siteSettings?.SiteIcon;
        return siteIcon?.MediaUrl();
    }

    }
}

