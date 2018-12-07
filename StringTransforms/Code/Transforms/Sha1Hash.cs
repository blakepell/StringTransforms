using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Sha1Hash : BaseTransform
    {
        public override string Name { get; set; } = "SHA1 Hash";

        public override string Description { get; set; } = "Creates the SHA1 hash for the specified string.";

        public override string Identifier { get; set; } = "Sha1Hash";

        public override string Transform(string text)
        {
            return Argus.Cryptography.HashUtilities.Sha1Hash(text);
        }

    }
}
