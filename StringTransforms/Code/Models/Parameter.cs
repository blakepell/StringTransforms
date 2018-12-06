using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringTransforms.Models
{
    public class Parameter
    {
        public Parameter()
        {

        }

        public Parameter(string name, string label)
        {
            this.Name = name;
            this.Label = label;
        }

        public Parameter(string name, string label, Type type)
        {
            this.Name = name;
            this.Label = label;
            this.Type = type;
        }

        public Parameter(string name, string label, Type type, string value)
        {
            this.Name = name;
            this.Label = label;
            this.Value = value;
            this.Type = type;
        }

        public string Name { get; set; } = "";

        public string Label { get; set; } = "";

        public string Value { get; set; } = "";

        public Type Type { get; set; }

    }
}
