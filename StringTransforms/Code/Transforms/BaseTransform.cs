using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public abstract class BaseTransform : ITransform
    {
        public abstract string Name { get; set; }

        public abstract string Description { get; set; }

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public abstract string Identifier { get; set; }

        public string Route
        {
            get
            {
                return Regex.Replace(Identifier, @"([a-z])([A-Z])", "$1-$2").ToLower();
            }
        }

        private int _paramCounter = 0;

        public void AddParameter(string label, Type type)
        {
            _paramCounter++;
            this.Parameters.Add(new Parameter($"param{_paramCounter.ToString()}", label, type));
        }

        public void SetParameterValue(string paramName, string paramValue)
        {
            foreach (var item in this.Parameters)
            {
                if (item.Name == paramName)
                {
                    item.Value = paramValue;
                }
            }
        }

        public abstract string Transform(string text);

    }
}
