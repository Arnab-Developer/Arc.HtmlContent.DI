using ArnabDeveloper.HtmlContent.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArnabDeveloper.HttpHealthCheck.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHtmlContentService(this IServiceCollection services) =>
            services.AddTransient(typeof(IHtmlContentService), typeof(HtmlContentService));
    }
}