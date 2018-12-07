using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class Md5Hash : BaseTransform
    {
        public override string Name { get; set; } = "MD5 Hash";

        public override string Description { get; set; } = "Creates the MD5 hash for the specified string.";

        public override string Identifier { get; set; } = "Md5Hash";

        public override string Transform(string text)
        {
            return Argus.Cryptography.HashUtilities.Md5Hash(text);
        }

    }
}
