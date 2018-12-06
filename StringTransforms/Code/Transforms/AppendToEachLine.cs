using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class AppendToEachLine : BaseTransform
    {
        public AppendToEachLine()
        {
            this.AddParameter("Append Text", Argus.Utilities.TypeUtilities.StringType());
        }

        public override string Name { get; set; } = "Append to Each Line";

        public override string Description { get; set; } = "Append text to each line of a string.";

        public override string Identifier { get; set; } = "AppendToEachLine";

        public override string Transform(string text)
        {
            string appendText = this.Parameters.FirstOrDefault(x => x.Label == "Append Text").Value;
            return Argus.Data.StringTransforms.WrapLines(text, "", appendText, "\n");
        }

    }
}
