using System;
using System.Collections.Generic;
using System.Text;
using RateApp.Core;

namespace RateApp.Data
{
    public interface IRateData
    {
        Rate GetById(int id);
        IEnumerable<Rate> GetRates();
        Rate Update(Rate updatedRate);
        Rate Add(Rate newRate);
        Rate Delete(int id);
        int Commit();
    }
}
