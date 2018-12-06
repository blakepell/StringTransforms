using System;
using System.Collections.Generic;
using System.Linq;
using StringTransforms.Models;
using System.Threading.Tasks;
using Argus.Extensions;

namespace StringTransforms.Code.Transforms
{
    public class FromBase64 : BaseTransform
    {
        public override string Name { get; set; } = "From Base64";

        public override string Description { get; set; } = "Converts Base64 to text.";

        public override string Identifier { get; set; } = "FromBase64";

        public override string Transform(string text)
        {
            return text.FromBase64();
        }

    }
}
