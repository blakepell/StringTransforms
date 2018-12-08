using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public class DateTimeToUnixEpoc : BaseTransform
    {
        public DateTimeToUnixEpoc()
        {
            this.AddParameter("Date/Time", Argus.Utilities.TypeUtilities.DateTimeType());
        }

        public override string Name { get; set; } = "Date/Time to Unix Epoch";

        public override string Description { get; set; } = "Converts a Date/Time into it's Unix Epoch Time equivalent.";

        public override string Identifier { get; set; } = "DateTimeToUnixEpoc";

        public override string Transform(string text)
        {
            string dateTime = this.Parameters.FirstOrDefault(x => x.Label == "Date/Time").Value;
            DateTime dt = DateTime.Parse(dateTime);
            return dt.ToUnixTimeStamp().ToString();
        }

    }
}
