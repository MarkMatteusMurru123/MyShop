using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages
{
    public class AbstractPage : PageModel
    {
        public void OnGetIndex()
        {

        }
        public string Caption { get; protected set; }
    }
}
