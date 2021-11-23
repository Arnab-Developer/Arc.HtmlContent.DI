using ArnabDeveloper.HtmlContent.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArnabDeveloper.HttpHealthCheck.DI;

/// <summary>
/// Service collection extensions
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add html content service
    /// </summary>
    /// <param name="services">IServiceCollection type object</param>
    /// <returns>IServiceCollection type object</returns>
    public static IServiceCollection AddHtmlContentService(this IServiceCollection services) =>
        services.AddTransient(typeof(IHtmlContentService), typeof(HtmlContentService));
}