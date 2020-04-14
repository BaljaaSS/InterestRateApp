using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RateApp.Core;
using RateApp.Data;

namespace RateApp.Pages.Rates
{
    public class RateListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRateData rateData;

        public RateListModel(IConfiguration config, IRateData RateData)
        {
            this.config = config;
            this.rateData = RateData;
        }

        public IEnumerable<Rate> Rates { get; set; }

        public void OnGet()
        {
            Rates = rateData.GetRates();
        }
    }
}