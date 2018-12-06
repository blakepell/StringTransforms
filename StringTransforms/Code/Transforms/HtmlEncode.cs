using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class HtmlEncode : ITransform
    {
        public string Name => "HTML Encode";

        public string Description => "HTML encodes a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "HtmlEncode";

        public string Transform(string text)
        {
            return text.HtmlEncode();
        }

    }
}
