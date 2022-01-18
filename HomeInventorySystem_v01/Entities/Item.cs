using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeInventorySystem_v01.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public int UserId { get; set; }
    }
}
