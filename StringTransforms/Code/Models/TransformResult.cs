using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringTransforms.Models
{
    public class TransformResult
    {
        public string Value { get; set; } = "";

        public bool Error { get; set; } = false;

        public string ErrorMessage { get; set; } = "";

    }
}
