using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RateApp.Core;
using System.Linq;

namespace RateApp.Data
{
    public class SqlRateData : IRateData
    {
        private readonly RateAppDbContext db;
        //readonly List<Rate> rates;

        public SqlRateData(RateAppDbContext db)
        {
            this.db = db;
            //rates = new List<Rate>()
            //{
            //    new Rate {Term = 10, OneTime = 2.88m, Monthly = 3.18m},
            //    new Rate {Term = 15, OneTime = 3.39m, Monthly = 3.84m},
            //    new Rate {Term = 20, OneTime = 3.54m, Monthly = 4.04m},
            //};
            //foreach (Rate rate in rates)
            //{
            //    db.Add(rate);
            //}
        }
        public Rate Add(Rate newRate)
        {
            newRate.Id = db.Rates.Count() + 1;
            db.Add(newRate);
            return newRate;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Rate Delete(int id)
        {
            var rate = GetById(id);
            if (rate != null)
            {
                db.Rates.Remove(rate);
            }
            return rate;
        }

        public Rate GetById(int id)
        {
            return db.Rates.Find(id);
        }

        public IEnumerable<Rate> GetRates()
        {
            return db.Rates;
        }

        public Rate Update(Rate updatedRate)
        {
            var entity = db.Rates.Attach(updatedRate);
            entity.State = EntityState.Modified;
            return updatedRate;
        }
    }
}
