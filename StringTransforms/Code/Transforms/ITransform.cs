using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringTransforms.Models;

namespace StringTransforms.Code.Transforms
{
    public interface ITransform
    {

        string Name { get; }

        string Description { get; }

        string Transform(string text);

        List<Parameter> Parameters { get; set; }

        string Identifier { get; }

        void AddParameter(string label, Type type);

    }
}
