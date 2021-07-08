using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.Desktop
{
    class Constants
    {
        public static string API = "https://cabinet-backend.herokuapp.com/api";
        public static string GET_ALL = Path.Combine(API, "person/get");
        public static string GET = Path.Combine(API, "person/get/");
        
    }
}
