using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StringTransforms.Code.Transforms;
using Argus.Extensions;
using StringTransforms.Models;

namespace StringTransforms.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
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
                    Transforms.Add(transform);
                }
            }

        }

        /// <summary>
        /// Performs the actual transform and returns the result.
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public JsonResult OnGetTransform(string transform, string text)
        {
            // Allow lookup by name but don't let it get out of our boxed in namespace.
            var type = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace == "StringTransforms.Code.Transforms" && t.IsInterface == false && t.Name == transform)
                        .FirstOrDefault();

            var tr = new TransformResult();

            try
            {
                var it = (ITransform)Activator.CreateInstance(type);                
                tr.Value = it.Transform(text);
            }
            catch (Exception ex)
            {
                tr.Value = text;
                tr.Error = true;
                tr.ErrorMessage = ex.Message;
            }

            return new JsonResult(tr);
        }
        
        public List<ITransform> Transforms { get; set; } = new List<ITransform>();

    }
}
