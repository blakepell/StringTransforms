using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringTransforms.Code.Transforms
{
    public class CreateGuid : BaseTransform
    {
        public override string Name { get; set; } = "Create GUID";

        public override string Description { get; set; } = "Create a new GUID.";

        public override string Identifier { get; set; } = "CreateGuid";

        public override string Transform(string text)
        {
            return Guid.NewGuid().ToString();
        }

    }
}
