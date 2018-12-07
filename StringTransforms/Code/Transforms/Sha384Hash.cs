using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Sha384Hash : BaseTransform
    {
        public override string Name { get; set; } = "SHA384 Hash";

        public override string Description { get; set; } = "Creates the SHA384 hash for the specified string.";

        public override string Identifier { get; set; } = "Sha384Hash";

        public override string Transform(string text)
        {
            return Argus.Cryptography.HashUtilities.Sha384Hash(text);
        }

    }
}
