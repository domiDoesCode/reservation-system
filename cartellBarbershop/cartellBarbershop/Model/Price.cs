using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Model
{
    internal class Price
    {
        public int Id { get; set; }
        public double SellingPrice { get; set; }
        public DateTime FromDate { get; set; }

        public Price(int _id, double _price, DateTime _fromDate)
        {
            this.Id = _id;
            this.SellingPrice = _price;
            this.FromDate = _fromDate;
        }       
    }
}
