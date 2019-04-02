using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab10.Pages
{
    public class BootstrapModel : PageModel
    {
        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName {get; set;}
        [BindProperty]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name ")]
        public string LastName{get; set;}

        [BindProperty]
        [Display(Name = "Credit Card")]
        [Required]
        [CreditCard]
        public string CardNumber{get; set;}


        private readonly ILogger _log;
        public BootstrapModel(ILogger<IndexModel> log)
            {
                _log = log;
            }
 
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            _log.LogWarning($"{FirstName}{LastName}");
        }

    }
}