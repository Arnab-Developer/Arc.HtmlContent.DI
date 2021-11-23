using ArnabDeveloper.HtmlContent.Core.Models;
using ArnabDeveloper.HtmlContent.Core.Services;
using ArnabDeveloper.HttpHealthCheck.DI;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ArnabDeveloper.HttpHealthCheck.DITests
{
    public class ServiceCollectionExtensionsTest
    {
        private IHtmlContentService? _htmlContentService;

        [Fact]
        public void Can_AddHtmlContentService_InjectDependency()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHtmlContentService();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            _htmlContentService = serviceProvider.GetRequiredService<IHtmlContentService>();

            Assert.NotNull(_htmlContentService);
            AddUrls();
            IEnumerable<WebSiteDataModel> webSiteDataModels = _htmlContentService.GetContent();
            CheckResults(webSiteDataModels);
        }

        private void AddUrls()
        {
            if (_htmlContentService == null) return;

            _htmlContentService.Urls.Add("http://google.com");
            _htmlContentService.Urls.Add("http://microsoft.com");
            _htmlContentService.Urls.Add("http://github.com");
            _htmlContentService.Urls.Add("http://bitbucket.com");
            _htmlContentService.Urls.Add("http://gmail.com");
            _htmlContentService.Urls.Add("http://office.com");
            _htmlContentService.Urls.Add("http://outlook.com");
            _htmlContentService.Urls.Add("http://www.businessinsider.com");
        }

        private void CheckResults(IEnumerable<WebSiteDataModel> webSiteDataModels)
        {
            Assert.Equal(8, webSiteDataModels.Count());
            foreach (WebSiteDataModel webSiteDataModel in webSiteDataModels)
            {
                Assert.NotNull(webSiteDataModel.WebsiteUrl);
                Assert.True
                (
                    webSiteDataModel.WebsiteUrl == "http://google.com" ||
                    webSiteDataModel.WebsiteUrl == "http://microsoft.com" ||
                    webSiteDataModel.WebsiteUrl == "http://github.com" ||
                    webSiteDataModel.WebsiteUrl == "http://bitbucket.com" ||
                    webSiteDataModel.WebsiteUrl == "http://gmail.com" ||
                    webSiteDataModel.WebsiteUrl == "http://office.com" ||
                    webSiteDataModel.WebsiteUrl == "http://outlook.com" ||
                    webSiteDataModel.WebsiteUrl == "http://www.businessinsider.com"
                );
                Assert.NotNull(webSiteDataModel.WebsiteData);
                Assert.True(webSiteDataModel.WebsiteData.Length != 0);
            }
        }
    }
}