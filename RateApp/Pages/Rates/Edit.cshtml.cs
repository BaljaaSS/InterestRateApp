using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RateApp.Core;
using RateApp.Data;

namespace RateApp.Pages.Rates
{
    public class EditModel : PageModel
    {
        private readonly IRateData rateData;
        [BindProperty]
        public Rate Rate{ get; set; }

        public EditModel(IRateData rateData)
        {
            this.rateData = rateData;
        }
        public IActionResult OnGet(int? rateId)
        {
            if (rateId.HasValue)
            {
                Rate = rateData.GetById(rateId.Value);
            }
            else
            {
                Rate = new Rate();   

            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                if (Rate.Id >0)
                {
                    Rate = rateData.Update(Rate);
                }
                else
                {
                    Rate = rateData.Add(Rate);
                }
                rateData.Commit();
                return RedirectToPage("./RateList");
            }
            return Page();
        }
    }
}