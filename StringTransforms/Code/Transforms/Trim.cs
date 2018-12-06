using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Trim : BaseTransform
    {
        public override string Name { get; set; } = "Trim";

        public override string Description { get; set; } = "Trims whitespace off of a string.";

        public override string Identifier { get; set; } = "Trim";

        public override string Transform(string text)
        {
            return text.Trim();
        }

    }
}
