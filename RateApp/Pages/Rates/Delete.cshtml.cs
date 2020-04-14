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
    public class DeleteModel : PageModel
    {
        private readonly IRateData rateData;

        public DeleteModel(IRateData rateData)
        {
            this.rateData = rateData;
        }

        public Rate Rate { get; set; }

        public IActionResult OnGet(int rateId)
        {
            Rate = rateData.GetById(rateId);
            return Page();
        }

        public IActionResult OnPost(int rateId)
        {
            var rate = rateData.Delete(rateId);
            rateData.Commit();
            return RedirectToPage("./RateList");
        }
    }
}