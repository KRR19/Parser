﻿using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserHabr.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;
        bool isActive;

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        public IParser<T> Parser 
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }

        }
        
        public IParserSettings Settings
        {
            get 
            {
                return parserSettings;
            }

            set 
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public  bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings): this(parser)
        {
            this.Settings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for(int i = Settings.StartPoint; i <= Settings.EndPoint; i++)
            {
                if(!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceById(i);
                var domParser = new HtmlParser();
                var document = await domParser.ParseAsync(source);

                var result = parser.Parse(document);
                OnNewData(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
