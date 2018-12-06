using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class TrimStart : ITransform
    {
        public string Name => "Trim Start";

        public string Description => "Trims whitespace off the beginning of a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "TrimStart";

        public string Transform(string text)
        {
            return text.TrimStart();
        }

    }
}
