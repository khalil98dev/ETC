using ETC_DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETC_BussinessLayer
{
    public class Class1
    {
        static public string Connection()
        {
            return clsDBSettings.ConnectionString;
        }
    }
}
