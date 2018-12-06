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
            //this.Parameters.Add(new Parameter("BeforeText", "Before Text", Argus.Utilities.TypeUtilities.StringType()));
            //this.Parameters.Add(new Parameter("AfterText", "After Text", Argus.Utilities.TypeUtilities.StringType()));
        }

        public override string Name { get; set; } = "Wrap Lines";

        public override string Description { get; set; } = "Prepends and appends text to each line in a string.";

        public override string Identifier { get; set; } = "WrapLines";

        public override string Transform(string text)
        {
            //string beforeText = this.Parameters.FirstOrDefault(p { get; set; } = p.Name == "BeforeText").Value;
            //string afterText = this.Parameters.Where(p { get; set; } = p.Name == "AfterText").FirstOrDefault()?.Value ?? "";

            return "Not implemented.";
        }

    }
}
