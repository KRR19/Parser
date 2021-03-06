﻿using AngleSharp.Dom.Html;

namespace ParserHabr.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
