using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System_New_Virsion.Classes
{
    public class clsRentals
    {
        public string ID { get; set; }
        public string Customer {  get; set; }
        public string Car { get; set; }
        public string Start_Rental { get; set; }
        public string End_Rental { get; set; }
        public string Discount { get; set; }
        public string PricePerDay { get; set; }
        public string TotalPrice { get; set; }
        public string Days { get; set; }
        public string ContractNo { get; set; }
        public string Can_Release_Car { get; set; }
    }
}
