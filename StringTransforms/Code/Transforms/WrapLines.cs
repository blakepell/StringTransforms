using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class WrapLines : BaseTransform
    {
        public WrapLines()
        {
            this.AddParameter("Before Text", Argus.Utilities.TypeUtilities.StringType());
            this.AddParameter("After Text", Argus.Utilities.TypeUtilities.StringType());
        }

        public override string Name { get; set; } = "Wrap Lines";

        public override string Description { get; set; } = "Prepends and appends text to each line in a string.";

        public override string Identifier { get; set; } = "WrapLines";

        public override string Transform(string text)
        {
            string beforeText = this.Parameters.FirstOrDefault(x => x.Label == "Before Text").Value;
            string afterText = this.Parameters.FirstOrDefault(x => x.Label == "After Text").Value;
            return Argus.Data.StringTransforms.WrapLines(text, beforeText, afterText, "\n");
        }

    }
}
