using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_marcher
{
    internal class stand
    {
        public stand(int place, string seller, int product, int quantity, string unit, float price)
        {
            this.place = place;
            this.seller = seller;
            this.product = product;
            this.quantity = quantity;
            this.unit = unit;
            this.price = price;
        }

        public int place { get; set; }
        public string seller { get; set; }
        public int product { get; set; }
        public int quantity { get; set; }
        public string unit { get; set; }
        public float price { get; set; }
    }
}
