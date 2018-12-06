using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class ToBase64 : ITransform
    {
        public string Name => "To Base64";

        public string Description => "Converts text to Base64.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "ToBase64";

        public string Transform(string text)
        {
            return text.ToBase64();
        }

    }
}
