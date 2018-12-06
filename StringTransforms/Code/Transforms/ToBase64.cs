using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class ToBase64 : BaseTransform
    {
        public override string Name { get; set; } = "To Base64";

        public override string Description { get; set; } = "Converts text to Base64.";

        public override string Identifier { get; set; } = "ToBase64";

        public override string Transform(string text)
        {
            return text.ToBase64();
        }

    }
}
