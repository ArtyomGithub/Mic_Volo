using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.ToDoConsole
{
    class PrintText
    {
        public static string mt = "\t\t\t";
        public static string st = "\t\t ";
        public static string xst = "\t\t";
        public static void header()
        {
            Console.Clear();
            DateTime dtu = DateTime.Now;
            Console.WriteLine("\n\n\n\t\t\t\t\t"+dtu.ToString("dd-MM-yyyy"));
            Console.WriteLine("\t\t===================================");
            Console.WriteLine("\t\t\t TO-DO List");
            Console.WriteLine("\t\t===================================");
        }
        public static void footer()
        {
            Console.WriteLine("\t\t====================================");
        }
        public static void UI_msg(string msg)
        {
            header();
            Console.WriteLine("\n\n"+st+msg+"\n\n");
            footer();
            Console.Write(st + "Press <any> key to continue:");
            Console.ReadKey();
        }
        public static bool chk_date(string daaat)
        {
            string[] formats = { "d-M-yyyy" };
            DateTime parsedDateTime;
            if(DateTime.TryParseExact(daaat,formats,new CultureInfo("en_US"),
                DateTimeStyles.None,out parsedDateTime))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
