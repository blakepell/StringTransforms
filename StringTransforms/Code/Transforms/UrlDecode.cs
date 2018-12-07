using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class UrlDecode : BaseTransform
    {
        public override string Name { get; set; } = "URL Decode";

        public override string Description { get; set; } = "Decodes a URL encoded string.";

        public override string Identifier { get; set; } = "UrlDecode";

        public override string Transform(string text)
        {
            return text.UrlDecode();
        }

    }
}
