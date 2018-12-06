using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class TrimEnd : ITransform
    {
        public string Name => "Trim End";

        public string Description => "Trims whitespace off the end of a string.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "TrimEnd";

        public string Transform(string text)
        {
            return text.TrimEnd();
        }

    }
}
