using System;
using System.Collections.Generic;
using System.Linq;
using StringTransforms.Models;
using System.Threading.Tasks;
using Argus.Extensions;

namespace StringTransforms.Code.Transforms
{
    public class HtmlDecode : BaseTransform
    {
        public override string Name { get; set; } = "HTML Decode";

        public override string Description { get; set; } = "HTML decodes a string.";

        public override string Identifier { get; set; } = "HtmlDecode";

        public override string Transform(string text)
        {
            return text.HtmlDecode();
        }

    }
}
