using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class PrependToEachLine : BaseTransform
    {
        public PrependToEachLine()
        {
            this.AddParameter("Prepend Text", Argus.Utilities.TypeUtilities.StringType());
        }

        public override string Name { get; set; } = "Prepend to Each Line";

        public override string Description { get; set; } = "Prepend text to each line of a string.";

        public override string Identifier { get; set; } = "PrependToEachLine";

        public override string Transform(string text)
        {
            string prependText = this.Parameters.FirstOrDefault(x => x.Label == "Prepend Text").Value;
            return Argus.Data.StringTransforms.WrapLines(text, prependText, "", "\n");
        }

    }
}
