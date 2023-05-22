using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDCManagementSystem
{
    public class Connection
    {
        public const string CONNECTION_STRING = @"Data Source=DESKTOP-2GGTQSU\SQLEXPRESS01;Initial Catalog=DDCManagementSystem;Integrated Security=True";
        public static Dictionary<string, string> dictServicePrice;
    }
}
