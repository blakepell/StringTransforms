using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StringTransforms.Code
{
    public class BasePageModel : PageModel
    {

        public string ActiveMenu { get; set; } = "";

    }
}
