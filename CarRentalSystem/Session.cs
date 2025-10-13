using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public static class Session
    {
        public static int Employee_ID;
        public static string UserName;
        public static int Role_ID; 
        public static string Role_Name; 
        public static List<string> Permissions = new List<string>();
    }
}
