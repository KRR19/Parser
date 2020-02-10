using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserHabr.Core.Habra
{
    class HabraPrser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            string[] list = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link")).Select(s => s.TextContent).ToArray();
            return list;
        }
    }
}
