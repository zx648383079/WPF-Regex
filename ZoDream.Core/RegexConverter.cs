﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoDream.Core
{
    public class RegexConverter
    {
        public IDictionary<string, string> Parameters { get; set; }

        public RegexConverter()
        {

        }

        public RegexConverter(IDictionary<string, string> parameter)
        {
            Parameters = parameter;
        }

        public string Get(string key)
        {
            return Get(key, string.Empty);
        }

        public string Get(string key, string defaultValue)
        {
            string arg;
            if (Parameters.TryGetValue(key, out arg))
            {
                return arg;
            }
            return defaultValue;
        }
    }
}
