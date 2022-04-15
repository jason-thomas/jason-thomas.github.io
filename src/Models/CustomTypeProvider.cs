using System;
using System.Collections.Generic;
using System.Linq;
using Kentico.Kontent.Delivery.Abstractions;

namespace StartBootstrap.Freelancer.Blazor.Models
{
    public class CustomTypeProvider : ITypeProvider
    {
        private static readonly Dictionary<Type, string> _codenames = new Dictionary<Type, string>
        {
            {typeof(ArticleExampleContentType), "article_example_content_type"},
            {typeof(LandingPageExampleContentType), "landing_page_example_content_type"},
            {typeof(ProductExampleContentType), "product_example_content_type"}
        };

        public Type GetType(string contentType)
        {
            return _codenames.Keys.FirstOrDefault(type => GetCodename(type).Equals(contentType));
        }

        public string GetCodename(Type contentType)
        {
            return _codenames.TryGetValue(contentType, out var codename) ? codename : null;
        }
    }
}