using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Data
{
   public class Boat:BaseEntity
    {
        
        public string BoatName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public DateTime Rentdate { get; set; }
        public int price { get; set; }
    }
}
