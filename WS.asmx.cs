using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<aSale> GetSalesByPeriod(DateTime DateFrom, DateTime DateTo)
        {
            List<aSale> aSales = new List<aSale>();
            aSales.Add(aSale1);
            aSales.Add(aSale2);
            aSales.Add(aSale3);
            aSales.Add(aSale4);
            aSales.Add(aSale5);
            var result = (from aSale in aSales where aSale.SaleDate >= DateFrom && aSale.SaleDate <= DateTo select aSale).ToList<aSale>();
            return aSales;
        }

        aSale aSale1 = new aSale()
        {
            SaleDate = new DateTime(2022, 10, 11, 16, 20, 17),
            SumKZT = 50000m,
            SumUSD = 50000m / 450m
        };
        aSale aSale2 = new aSale()
        {
            SaleDate = new DateTime(2022, 7, 9, 10, 25, 17),
            SumKZT = 35000m,
            SumUSD = 35000m / 450m
        };
        aSale aSale3 = new aSale()
        {
            SaleDate = new DateTime(2022, 1, 5, 12, 20, 17),
            SumKZT = 80000m,
            SumUSD = 80000m / 450m
        };
        aSale aSale4 = new aSale()
        {
            SaleDate = new DateTime(2022, 6, 1, 9, 20, 17),
            SumKZT = 12000m,
            SumUSD = 12000m / 450m
        };
        aSale aSale5 = new aSale()
        {
            SaleDate = new DateTime(2022, 13, 6, 16, 20, 17),
            SumKZT = 56000m,
            SumUSD = 56000m / 450m
        };
    }
   
        
}
