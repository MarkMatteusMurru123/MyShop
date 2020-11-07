using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Soft.Extensions
{
    public static class ButtonsHtml
    {
        public static IHtmlContent Buttons(this IHtmlHelper h, string id)
        {
            var s = HtmlStrings(h, id);
            return new HtmlContentBuilder(s);
        }

        private static List<object> HtmlStrings(IHtmlHelper h, string id)
        {
            return new List<object>
            {
                new HtmlString($"<a href=\"./Edit?handler=edit&id={id}\">Edit</a>|"),
                new HtmlString($"<a href=\"./Details?handler=details&id={id}\">Details</a>|"),
                new HtmlString($"<a href=\"./Delete?handler=delete&id={id}\">Delete</a>")
            };

        }
    }
}
