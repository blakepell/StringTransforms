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
    public class TestModel : BasePageModel
    {
        public TestModel()
        {
            this.ActiveMenu = "Home";
        }

        public void OnGet()
        {

        }

    }
}
