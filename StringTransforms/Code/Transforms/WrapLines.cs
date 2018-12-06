using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class WrapLines : ITransform
    {
        public WrapLines()
        {
            this.Parameters.Add(new Parameter("BeforeText", "Before Text", Argus.Utilities.TypeUtilities.StringType()));
            this.Parameters.Add(new Parameter("AfterText", "After Text", Argus.Utilities.TypeUtilities.StringType()));
        }

        public string Name => "Wrap Lines";

        public string Description => "Prepends and appends text to each line in a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "WrapLines";

        public string Transform(string text)
        {
            string beforeText = this.Parameters.FirstOrDefault(p => p.Name == "BeforeText").Value;
            string afterText = this.Parameters.Where(p => p.Name == "AfterText").FirstOrDefault()?.Value ?? "";
         
            return text.ToWrappedString(beforeText, afterText);
        }

    }
}
