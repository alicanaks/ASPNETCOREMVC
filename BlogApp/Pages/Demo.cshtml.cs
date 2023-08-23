using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogApp.Pages
{
    
	public class DemoModel : PageModel
    {
        public string? FullName => HttpContext?.Session?.GetString("name") ?? "EMPTY"; 

    
         
        public void OnGet()
        {  
        }

        public void OnPost([FromForm]string  name)
        {
            //FullName = name;
            HttpContext.Session.SetString("name", name);

        }
    }  
}
