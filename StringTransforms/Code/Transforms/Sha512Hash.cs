using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Sha512Hash : BaseTransform
    {
        public override string Name { get; set; } = "SHA512 Hash";

        public override string Description { get; set; } = "Creates the SHA512 hash for the specified string.";

        public override string Identifier { get; set; } = "Sha512Hash";

        public override string Transform(string text)
        {
            return Argus.Cryptography.HashUtilities.Sha512Hash(text);
        }

    }
}
