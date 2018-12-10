using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using StringTransforms.Code.Transforms;

namespace StringTransforms.Code
{
    public static class Utilities
    {

        /// <summary>
        /// Returns the available list of transforms in the site.
        /// </summary>
        /// <returns></returns>
        public static List<ITransform> TransformList()
        {
            var list = new List<ITransform>();
            var transformList = Assembly
                                .GetExecutingAssembly()
                                .GetTypes()
                                .Where(t => t.Namespace == "StringTransforms.Code.Transforms" && !t.IsInterface && !t.IsAbstract)
                                .ToList();

            foreach (var item in transformList)
            {
                // Activator behaves weird when there are linq queries inside any of the methods on what
                // we create... after we activate this way we need to check for a null type (when a linq query
                // is run it seems to create a weird generic type that then throws a cast call when crammed into
                // our list).
                var transform = Activator.CreateInstance(item) as ITransform;

                if (transform != null)
                {
                    list.Add(transform);
                }

            }

            return list;
        }
    }
}
