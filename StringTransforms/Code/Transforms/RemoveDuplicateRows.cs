using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;
using System.Text;

namespace StringTransforms.Code.Transforms
{
    public class RemoveDuplicateRows : BaseTransform
    {
        public override string Name { get; set; } = "Remove Duplicate Rows";

        public override string Description { get; set; } = "Removes duplicate rows from a string.";

        public override string Identifier { get; set; } = "RemoveDuplicateRows";

        public override string Transform(string text)
        {
            var sb = new StringBuilder();
            var lines = text.Split("\n").Distinct();

            foreach (var line in lines)
            {
                sb.AppendFormat("{0}\n", line);
            }

            return sb.ToString();
        }

    }
}
