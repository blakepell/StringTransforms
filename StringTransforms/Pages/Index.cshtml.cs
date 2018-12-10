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
using StringTransforms.Code;

namespace StringTransforms.Pages
{
    public class IndexModel : BasePageModel
    {
        public IndexModel()
        {
            this.ActiveMenu = "Home";
        }

        public void OnGet()
        {
            Transforms = Utilities.TransformList();
        }

        /// <summary>
        /// Performs the actual transform and returns the result.
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult OnPostTransform()
        {
            // Model binding was failing so I manually requested everything from the form which works wonderfully.
            string transform = Request.Form["transform"].ToString();
            string text = Request.Form["text"].ToString();

            var tr = new TransformResult();

            if (string.IsNullOrWhiteSpace(transform))
            {
                tr.Value = text;
                tr.Error = true;
                tr.ErrorMessage = "Transform not provided.";
                return new JsonResult(tr);
            }

            text = text ?? "";

            // Allow lookup by name but don't let it get out of our boxed in namespace.
            var type = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace == "StringTransforms.Code.Transforms" && t.IsInterface == false && t.Name == transform)
                        .FirstOrDefault();

            try
            {
                var it = (ITransform)Activator.CreateInstance(type);

                // Find our dynamic parameters and set them.  Parameters that don't exist will
                // just get ignored.
                for (int i = 1; i <= 9; i++)
                {
                    it.SetParameterValue($"param{i}", Request.Form[$"param{i}"].ToString() ?? "");
                }

                // Execute the transform
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
