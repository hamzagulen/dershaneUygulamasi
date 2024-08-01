// HtmlHelpers.cs
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace efcoreApp.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlContent WelcomeMessage(this IHtmlHelper htmlHelper)
        {
            var welcomeMessage = "<h2>Hoş Geldiniz</h2>";
            return new HtmlString(welcomeMessage);
        }
    }
}
