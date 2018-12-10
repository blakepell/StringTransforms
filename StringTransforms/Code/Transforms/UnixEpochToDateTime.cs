using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class UnixEpocToDateTime : BaseTransform
    {
        public UnixEpocToDateTime()
        {
            this.AddParameter("Unix Epoch", Type.GetType("System.Double"));
        }

        public override string Name { get; set; } = "Unix Epoch to Date/Time";

        public override string Description { get; set; } = "Converts a Unix Epoch (number) into date/time equivalent.";

        public override string Identifier { get; set; } = "UnixEpocToDateTime";

        public override string Transform(string text)
        {
            string epochString = this.Parameters.FirstOrDefault(x => x.Label == "Unix Epoch").Value;
            var epoch = double.Parse(epochString);
            var dt = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(epoch));
            return dt.ToString();
        }

    }
}
