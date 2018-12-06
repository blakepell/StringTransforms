using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class TrimStart : BaseTransform
    {
        public override string Name { get; set; } = "Trim Start";

        public override string Description { get; set; } = "Trims whitespace off the beginning of a string.";

        public override string Identifier { get; set; } = "TrimStart";

        public override string Transform(string text)
        {
            return text.TrimStart();
        }

    }
}
