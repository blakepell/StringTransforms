using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class UrlEncode : BaseTransform
    {
        public override string Name { get; set; } = "URL Encode";

        public override string Description { get; set; } = "Encodes a string for use in a URL.";

        public override string Identifier { get; set; } = "UrlEncode";

        public override string Transform(string text)
        {
            return text.UrlEncode();
        }

    }
}
