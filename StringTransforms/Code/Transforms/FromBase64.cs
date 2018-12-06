using System;
using System.Collections.Generic;
using System.Linq;
using StringTransforms.Models;
using System.Threading.Tasks;
using Argus.Extensions;

namespace StringTransforms.Code.Transforms
{
    public class FromBase64 : ITransform
    {
        public string Name => "From Base64";

        public string Description => "Converts Base64 to text.";

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public string Identifier => "FromBase64";

        public string Transform(string text)
        {
            return text.FromBase64();
        }

    }
}
