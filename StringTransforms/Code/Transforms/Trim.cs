using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Trim : ITransform
    {
        public string Name => "Trim";

        public string Description => "Trims whitespace off of a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "Trim";

        public string Transform(string text)
        {
            return text.Trim();
        }

    }
}
