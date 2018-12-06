using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class TrimEnd : BaseTransform
    {
        public override string Name { get; set; } = "Trim End";

        public override string Description { get; set; } = "Trims whitespace off the end of a string.";

        public override string Identifier { get; set; } = "TrimEnd";

        public override string Transform(string text)
        {
            return text.TrimEnd();
        }

    }
}
