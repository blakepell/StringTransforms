using System;
using System.Collections.Generic;
using System.Linq;
using StringTransforms.Models;
using System.Threading.Tasks;
using Argus.Extensions;

namespace StringTransforms.Code.Transforms
{
    public class HtmlDecode : ITransform
    {
        public string Name => "HTML Decode";

        public string Description => "HTML decodes a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "HtmlDecode";

        public string Transform(string text)
        {
            return text.HtmlDecode();
        }

    }
}
