using Microsoft.EntityFrameworkCore;
using RateApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RateApp.Data
{
    public class RateAppDbContext: DbContext
    {
        public DbSet<Rate> Rates{ get; set; }
        public RateAppDbContext(DbContextOptions<RateAppDbContext> options): base(options)
        {

        }
    }
}
