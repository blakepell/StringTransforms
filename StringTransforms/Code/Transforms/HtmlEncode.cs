using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class HtmlEncode : BaseTransform
    {
        public override string Name { get; set; } = "HTML Encode";

        public override string Description { get; set; } = "HTML encodes a string.";

        public override string Identifier { get; set; } = "HtmlEncode";

        public override string Transform(string text)
        {
            return text.HtmlEncode();
        }

    }
}
