using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.ToDoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ID = rnd.Next(89);
            List<To_do> TD_Task = new List<To_do>();
            bool check = true;

            SUDO_MAIN:
            while (true)
            {
                PrintText.header();
                Console.WriteLine(PrintText.xst+"1.New Task.\t\t6.Update Task.\n");
                Console.WriteLine(PrintText.xst+"2.View All.\t\t7.Delete Task.\n");
                Console.WriteLine(PrintText.xst+"3.Find Task.\t\t9.Exit.\n");
                Console.WriteLine(PrintText.xst+"3.Find Duplicates\n");
                PrintText.footer();

                Console.Write(PrintText.st + "Enter your choice: ");
                int ch = 0;
                try
                {
                    ch = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    PrintText.UI_msg("Error: Enter only integers!");
                }
                switch (ch)
                {
                    case 1:
                        PrintText.header();
                        Console.Write("\t\t Enter the Date.\t[dd-MM-yyyy]\n\t\t");
                        try
                        {
                            string dat = Console.ReadLine();
                            string daat = dat;
                            DateTime cur_time = DateTime.Now;
                            cur_time.ToString("d-M-yyyy");
                            try
                            {
                                TimeSpan duration = DateTime.Parse(cur_time.ToString()) - (DateTime.Parse(dat.ToString()));
                                int day = (int)Math.Round(duration.TotalDays);
                                int x = 0;
                                if(day%2!=0)
                                {
                                    x = 2;
                                }
                                else
                                {
                                    x = 1;
                                }

                                if(day>=x)
                                {
                                    DateTime dtu = DateTime.Now;
                                    string msg = "Plz select date from\n\t\t" + dtu.ToString("d-M-yyyy") + "pnwards!";
                                    PrintText.UI_msg("Error: " + msg);
                                    goto SUDO_MAIN;
                                }
                            }
                            catch (FormatException)
                            {
                                PrintText.UI_msg("Error: Invalid Date!");
                                goto SUDO_MAIN;
                            }
                            if(PrintText.chk_date(daat))
                            {
                                Console.Write("\n\t\t Enter Task.\n\t\t");
                                string msg = Console.ReadLine();
                                Console.Write("\n\t Enter Level of Importance.\t[1-5]\n\t\t");
                                int lvl = int.Parse(Console.ReadLine());
                                if(lvl>=1 && lvl<=5)
                                {
                                    ID++;
                                    TD_Task.Add(new To_do(ID, DateTime.Parse(dat), msg, lvl));
                                    PrintText.UI_msg("New Task created with Task ID = " + ID.ToString());
                                    TD_Task.Sort();
                                }
                                else
                                {
                                    PrintText.UI_msg("Error: Only between[1-5]!");
                                }
                            }
                            else
                            {
                                PrintText.UI_msg("Error: Invalid Date!");
                            }
                        }
                        catch (Exception)
                        {
                            PrintText.UI_msg("Error: Enter Integer Only!");
                        }
                        break;
                    case 2:
                        PrintText.header();
                        Console.WriteLine("\t\t ID \t Date\tTask\t\tLevel");
                        foreach (To_do t in TD_Task)
                        {
                            check = false;
                            Console.WriteLine("\t\t"+t.Todo_ID+" "+t.date.ToString("dd-MM-yyyy")+"\t"+t.Task+"\t\t"+t.Lvl_Imp);
                        }
                        if(check)
                        {
                            Console.WriteLine("\n\n\t\t\t No Records Found!\n\n");
                        }
                        PrintText.footer();
                        Console.Write(PrintText.st + "Press <any> key to continue: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        PrintText.header();
                        string cmp_date1, mon1, day1, S_d, E_d, S_m, E_m, S_da, E_da;
                        int SD, ED, cmp_date, mon, SM, EM, dayx, SDA, EDA;
                        Console.Write("\t\t Enter starting Date.\t[dd-MM-yyyy]\n\t\t");
                        string Sdat3 = Console.ReadLine();
                        if(PrintText.chk_date(Sdat3))
                        {
                            Console.Write("\n\t\tEnter ending Date.\t[dd-MM-yyyy]\n\t\t");
                            string Edat3 = Console.ReadLine();
                            Console.WriteLine("\t\t-------------------------------------");
                            Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                            if(PrintText.chk_date(Edat3))
                            {
                                DateTime s = DateTime.Parse(Sdat3);
                                DateTime e = DateTime.Parse(Edat3);
                                for (int i = 0; i < TD_Task.Count; i++)
                                {
                                    //year
                                    cmp_date1 = TD_Task[i].date.ToString("yyyy");
                                    cmp_date = int.Parse(cmp_date1);
                                    S_d = s.ToString("yyyy");
                                    E_d = e.ToString("yyyy");
                                    SD = int.Parse(S_d);
                                    ED = int.Parse(E_d);
                                    //month
                                    mon1 = TD_Task[i].date.ToString("MM");
                                    mon = int.Parse(mon1);
                                    S_m = s.ToString("MM");
                                    E_m = e.ToString("MM");
                                    SM = int.Parse(S_m);
                                    EM = int.Parse(E_m);
                                    //day
                                    day1 = TD_Task[i].date.ToString("dd");
                                    dayx = int.Parse(day1);
                                    S_da = s.ToString("dd");
                                    E_da = e.ToString("dd");
                                    SDA = int.Parse(S_da);
                                    EDA = int.Parse(E_da);
                                    if(cmp_date>=SD && cmp_date<=ED)
                                    {
                                        if(mon>=SM && mon<=EM)
                                        {
                                            if(dayx>=SDA && dayx<=EDA)
                                            {
                                                check = false;
                                                Console.WriteLine("\t\t"+TD_Task[i].Todo_ID+" "+TD_Task[i].date.ToString("dd-MM-yyyy")+"\t "+TD_Task[i].Task+"\t"+TD_Task[i].Lvl_Imp);
                                            }
                                        }
                                    }
                                }
                                if(check)
                                {
                                    Console.WriteLine("n\n\t\t\tNo Records Found!\n\n");
                                }
                                PrintText.footer();
                                Console.Write(PrintText.st + "Press <any> key to continue: ");
                                Console.ReadKey();
                            }
                            else
                            {
                                PrintText.UI_msg("Error: Invalid Ending Date!");
                            }
                        }
                        else
                        {
                            PrintText.UI_msg("Error: Invalid Starting Date!");
                        }
                        break;
                    case 4:
                        PrintText.header();
                        Console.Write("\t\tEnter the String.\n\t\t");
                        try
                        {
                            string str1;
                            string str = Console.ReadLine();
                            str.ToLower();
                            Console.WriteLine("\t\t----------------------------------------");
                            Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                            for (int i = 0; i < TD_Task.Count; i++)
                            {
                                str1 = TD_Task[i].Task;
                                str1.ToLower();
                                if(str1.Contains(str))
                                {
                                    check = false;
                                    Console.WriteLine("\t\t"+TD_Task[i].Todo_ID+" "+TD_Task[i].date.ToString("dd-MM-yyyy")+"\t"+TD_Task[i].Task+"\t"+TD_Task[i].Lvl_Imp);
                                }
                            }
                            if(check)
                            {
                                Console.WriteLine("\n\n\t\t\tNo Records Found!\n\n");
                            }
                            PrintText.footer();
                            Console.Write(PrintText.st + "Press <any> key to continue: ");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            PrintText.UI_msg("Error in Find string");
                        }
                        break;
                    case 5:
                        PrintText.header();
                        Console.WriteLine("\t\t--------------------------------");
                        Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                        string a;
                        int z = 0;
                        foreach (To_do y in TD_Task)
                        {
                            a = y.Task;
                            z = 0;
                            foreach (To_do x in TD_Task)
                            {
                                if (a.Equals(x.Task))
                                {
                                    z++;
                                }
                            }
                            if(z>=2)
                            {
                                check = false;
                                Console.WriteLine("\t\t"+y.Todo_ID+" "+y.date.ToString("dd-MM-yyyy")+"\t"+y.Task+"\t"+y.Lvl_Imp);
                            }
                        }
                        PrintText.footer();
                        Console.Write(PrintText.st + "Press <any> key to continue:");
                        Console.ReadKey();
                        break;
                    case 6:
                        PrintText.header();
                        Console.Write("\t\tEnter the Task_ID.\n\t\t");
                        try
                        {
                            int T_ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t-----------------------------------");
                            for (int i = 0; i < TD_Task.Count; i++)
                            {
                                if(TD_Task[i].Todo_ID==T_ID)
                                {
                                    check = false;
                                    Console.Write("\t\tEnter the DAte.\t[dd-MM-yyyy]\n\t\t");
                                    try
                                    {
                                        string dat = Console.ReadLine();
                                        string daat = dat;
                                        DateTime cur_time = DateTime.Now;
                                        cur_time.ToString("d-M-yyyy");
                                        try
                                        {
                                            TimeSpan duration = DateTime.Parse(cur_time.ToString()) - (DateTime.Parse(dat.ToString()));
                                            int day = (int)Math.Round(duration.TotalDays);
                                            if(day>=2)
                                            {
                                                DateTime dtu = DateTime.Now;
                                                string msg="Plz select date from\n\t\t" + dtu.ToString("d-M-yyyy") + " onwards!";
                                                PrintText.UI_msg("Error: " + msg);
                                                goto SUDO_MAIN;
                                            }
                                        }
                                        catch (FormatException)
                                        {
                                            PrintText.UI_msg("Error: Invalid Date!");
                                            goto SUDO_MAIN;
                                        }
                                        if(PrintText.chk_date(daat))
                                        {
                                            Console.Write("\n\t\tEnter Task.\n\t\t");
                                            string msg = Console.ReadLine();
                                            Console.Write("\n\t\t Enter Level of Importance.\t[1-5]\n\t\t");
                                            int lvl = int.Parse(Console.ReadLine());
                                            if(lvl>=1 && lvl<=5)
                                            {
                                                TD_Task[i].date = DateTime.Parse(dat);
                                                TD_Task[i].Task = msg;
                                                TD_Task[i].Lvl_Imp = lvl;

                                                Console.WriteLine("\t\tTask Updated!");
                                                TD_Task.Sort();
                                            }
                                            else
                                            {
                                                PrintText.UI_msg("Error: only between [1-5]");
                                            }
                                        }
                                        else
                                        {
                                            PrintText.UI_msg("Error: Invalid Date!");
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        PrintText.UI_msg("Error: Enter Integer Only!");
                                    }
                                }
                                if(check)
                                {
                                    Console.WriteLine("\n\n\t\t\t No Record Found!\n\n");
                                }
                                PrintText.footer();
                                Console.Write(PrintText.st + "Press <any> key to continue: ");
                                Console.ReadKey();
                            }
                        }
                        catch (Exception)
                        {
                            PrintText.UI_msg("Error: Insert Only Integers!");
                        }
                        break;

                    case 7:
                        PrintText.header();
                        Console.Write("\t\tEnter the Task_ID.\n\t\t");
                        try
                        {
                            int T_ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t------------------------------------");
                            for (int i = 0; i < TD_Task.Count; i++)
                            {
                                if (TD_Task[i].Todo_ID == T_ID)
                                {
                                    check = false;
                                    TD_Task.RemoveAll(e => e.Todo_ID == T_ID);
                                }
                            }
                            if (check)
                            {
                                Console.WriteLine("\n\n\t\t\t No Record Found!\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\n\t\t\t Record Deleted!\n\n");

                            }
                            PrintText.footer();
                            Console.Write(PrintText.st + "Press <any> key to continue:");
                            Console.ReadKey();

                        }
                        catch (Exception)
                        {

                            PrintText.UI_msg("ERROR: Insert Only Intergers!");
                        }
                        break;


                    case 8:

                        while (true)
                        {
                            PrintText.header();
                            Console.WriteLine("\t\t\t1.Sort By ID.");
                            Console.WriteLine("\t\t\t2.Sort By DATE.");
                            Console.WriteLine("\t\t\t3.Sort By Level Of Importance.");
                            Console.WriteLine("\t\t\t4.Exit.");
                            PrintText.footer();
                            Console.Write(PrintText.st + "Enter your choice: ");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {

                                case 1:

                                    PrintText.header();
                                    Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                                    Console.WriteLine("\t\t------------------------------------");
                                    TD_Task = TD_Task.OrderBy(x => x.Todo_ID).ToList();
                                    foreach (To_do x in TD_Task)
                                    {
                                        check = false;
                                        Console.WriteLine("\t\t" + x.Todo_ID + "  " + x.date.ToString("dd-MM-yyyy") + "\t" + x.Task + "\t" + x.Lvl_Imp);
                                    }
                                    if (check)
                                    {
                                        Console.WriteLine("\n\n\t\t\tNo Records Found!\n\n");
                                    }
                                    PrintText.footer();
                                    TD_Task = TD_Task.OrderBy(x => x.date).ToList();

                                    Console.Write(PrintText.st + "Press <any> key to continue:");
                                    Console.ReadKey();

                                    break;

                                case 2:

                                    PrintText.header();
                                    Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                                    Console.WriteLine("\t\t------------------------------------");
                                    TD_Task = TD_Task.OrderBy(x => x.date).ToList();
                                    foreach (To_do x in TD_Task)
                                    {
                                        check = false;
                                        Console.WriteLine("\t\t" + x.Todo_ID + "  " + x.date.ToString("dd-MM-yyyy") + "\t" + x.Task + "\t" + x.Lvl_Imp);
                                    }
                                    if (check)
                                    {
                                        Console.WriteLine("\n\n\t\t\tNo Records Found!\n\n");
                                    }
                                    PrintText.footer();
                                    TD_Task = TD_Task.OrderBy(x => x.date).ToList();

                                    Console.Write(PrintText.st + "Press <any> key to continue:");
                                    Console.ReadKey();

                                    break;

                                case 3:

                                    PrintText.header();
                                    Console.WriteLine("\t\tID \tDate\tTask\tLevel");
                                    Console.WriteLine("\t\t------------------------------------");
                                    TD_Task = TD_Task.OrderBy(x => x.Lvl_Imp).ToList();
                                    TD_Task.Reverse();
                                    foreach (To_do x in TD_Task)
                                    {
                                        check = false;
                                        Console.WriteLine("\t\t" + x.Todo_ID + "  " + x.date.ToString("dd-MM-yyyy") + "\t" + x.Task + "\t" + x.Lvl_Imp);
                                    }
                                    if (check)
                                    {
                                        Console.WriteLine("\n\n\t\t\tNo Records Found!\n\n");
                                    }
                                    PrintText.footer();
                                    TD_Task = TD_Task.OrderBy(x => x.date).ToList();

                                    Console.Write(PrintText.st + "Press <any> key to continue:");
                                    Console.ReadKey();

                                    break;
                                case 4:
                                    goto SUDO_MAIN;


                                default:
                                    PrintText.UI_msg("Invalid choice!");
                                    break;
                            }

                        }

                    case 9:
                        Environment.Exit(0);
                        break;

                    default:
                        PrintText.UI_msg("Invalid choice!");
                        break;
                }
            }
        }
    }
}
