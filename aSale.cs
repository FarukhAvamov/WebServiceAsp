using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace WebService
{
    public class aSale
    {
        //SaleDate, SumKZT, SumUSD
        public DateTime SaleDate { get; set; }
        public decimal SumKZT { get; set; }
        public decimal SumUSD { get; set; }
    }
}