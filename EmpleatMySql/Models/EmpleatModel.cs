using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpleatMySql.Models
{
    public class EmpleatModel:PageModel
    {
        public Empleat Empleat { get; set; }
        public void OnGet()
        {
            
        }

    }
}
