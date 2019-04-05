using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LINQGroupBy
{
    class MyUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string[] temas = { "Bavaria", "Borussia", "Real Madrid", "Manchester City", "PSG", "Barcelona" };
            //var selectedTeams = new List<string>();
            //foreach (string s in temas)
            //{
            //    if (s.ToUpper().StartsWith("B"))
            //        selectedTeams.Add(s);
            //}
            //selectedTeams.Sort();
            //foreach (string s in selectedTeams)
            //{
            //    Console.WriteLine(s);
            //}
            //var sTeams = from t in temas
            //             where t.ToUpper().StartsWith("B")
            //             orderby t
            //             select t;
            //foreach (string s in sTeams)
            //{
            //    Console.WriteLine(s);
            //}
            //var selected = temas.Where(t => t.ToUpper().StartsWith("B")).OrderBy(t => t);
            //foreach (string s in selected)
            //{
            //    Console.WriteLine(s);
            //}
            //int[] numbers = { 12, 3, 4, 5, 6, 5, 76, 6, 86, 5, 4, 3, 2, 4 };
            //IEnumerable<int> evens = numbers.Where(x => (x % 2 == 0 && x > 10)).Select(x => x);
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}
            //IEnumerable<int> values = from i in numbers
            //                          where i % 2 == 0 && i > 10
            //                          select i;
            //foreach (var item in values)
            //{
            //    Console.WriteLine("-----");
            //    Console.WriteLine(item);
            //}
            //IEnumerable<int> V = numbers.Where(i => i % 2 == 0 && i > 10);
            //foreach (var item in V)
            //{
            //    Console.Write(item + " ");
            //}
            //List<User> users = new List<User>
            //{
            //    new User{Name="Tom",Age=23,Languages=new List<string>{"English","German"}},
            //    new User{Name="Bob",Age=27,Languages=new List<string>{"English","France"}},
            //    new User{Name="Jon",Age=29,Languages=new List<string>{"English","Espanol"}},
            //    new User{Name="Elis",Age=24,Languages=new List<string>{"Espanol","German"}},
            //};
            //var selectedUsers = users.Where(x => x.Age > 25);
            //foreach (User item in selectedUsers)
            //{
            //    Console.WriteLine("{0}-{1}",item.Name,item.Age);
            //}
            //var LangSel = from user in users
            //              from lang in user.Languages
            //              where user.Age > 23
            //              where lang == "English"
            //              select user;
            //foreach (var L in LangSel)
            //{
            //    Console.WriteLine(L.Name);
            //}

            //List<MyUser> Users1 = new List<MyUser>();
            //Users1.Add(new MyUser { Name = "Sam", Age = 43 });
            //Users1.Add(new MyUser { Name = "Tom", Age = 33 });
            //var namesss = from i in Users1
            //              select i.Name;
            //foreach (string item in namesss)
            //{
            //    Console.WriteLine(item);
            //}
            //var it = from i in Users1
            //         select new
            //         {
            //             FirstName = i.Name,
            //             DateOfBirth = DateTime.Now.Year - i.Age
            //         };
            //foreach (var m in it)
            //{
            //    Console.WriteLine("{0}-{1}",m.FirstName,m.DateOfBirth);
            //}
            //var us = users.Select(u => u.Name);
            //var I = users.Select(i => new
            //{
            //    FirstName = i.Name,
            //    DateOfBirth = DateTime.Now.Year - i.Age
            //});

            //var people = from u in users
            //             let name = "Mr. " + u.Name
            //             select new
            //             {
            //                 Name = name,
            //                 Age = u.Age
            //             };

            List<User> users = new List<User>()
            {
                new User{Name="Sam",Age=43},
                new User{Name="Tom",Age=33},
                new User{Name="Tom",Age=21},
                new User{Name="Sam",Age=43}
            };
            List<Phone> phones = new List<Phone>()
            {
                new Phone{Name="Lumia 630",Company="Microsoft"},
                new Phone{Name="Iphone 6",Company="Apple"}
            };

            var people = from user in users
                         from phone in phones
                         select new
                         {
                             Name = user.Name,
                             Phone = phone.Name
                         };
            foreach (var p in people)
            {
                Console.WriteLine("{0}-{1}",p.Name,p.Phone);
            }
            int[] numbers = { 4, 5, 4, 6, 56, 57, 3, 4, 64, 57, 5, 4, 4, 3, 434, 34 };
            var orderedNumbers = from i in numbers
                                 orderby i
                                 select i;
            foreach (int  i in orderedNumbers)
            {
                Console.WriteLine(i);
            }

            var sortedUsers = from u in users
                              orderby u.Name
                              select u;
            foreach (User user in sortedUsers)
            {
                Console.WriteLine(user.Name);
            }
            IEnumerable<int> sortNum = numbers.OrderBy(i => i);
            var SortUs = users.OrderBy(u => u.Name);
            var result = from user in users
                         orderby user.Name, user.Age
                         select user;
            foreach (User item in result)
            {
                Console.WriteLine("{0}-{1}",item.Name,item.Age);
            }
            var ExtVers = users.OrderBy(u => u.Name).ThenBy(u => u.Age);
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };
            var resultExc = soft.Except(hard);
            foreach (string s in resultExc)
            {
                Console.WriteLine(s);
            }
            var resultIntersect = soft.Intersect(hard);
            foreach (string s in resultIntersect)
            {
                Console.WriteLine(s);
            }
            var resultUnion = soft.Union(hard).Distinct();
            foreach (string s in resultUnion)
            {
                Console.WriteLine(s);
            }
            var resConcat = soft.Concat(hard);
            foreach (string s in resConcat)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("************************");
            int[] numberAggregate = { 1, 2, 3, 4, 5 ,22};

            int query = numberAggregate.Aggregate((x, y) => x - y);
            int qu = numberAggregate.Aggregate((x, y) => x + y);
            Console.WriteLine(qu);

            int size = (from i in numberAggregate
                        where i % 2 == 0 && i > 10
                        select i).Count();
            Console.WriteLine(size);
            int S = numberAggregate.Count(i => i % 2 == 0 && i > 10);
            Console.WriteLine(S);

            List<User> users1 = new List<User>()
            {
                new User{Name="Tom",Age=23},
                new User{Name="Sam",Age=43},
                new User{Name="Bill",Age=35}
            };
            int Summ = numberAggregate.Sum();
            decimal sum2 = users1.Sum(n => n.Age);

            int min1 = numberAggregate.Min();
            int min2 = users1.Min(n => n.Age);

            int max1 = numberAggregate.Max();
            int max2 = users1.Max(u => u.Age);

            double Avr1 = numberAggregate.Average();
            double Avr2 = users1.Average(n => n.Age);

            Console.WriteLine("****-----******");
            int[] Nums = { -3, -2, -1, 0, 1, 2, 3 };
            var Rez = Nums.Take(3);
            foreach (int i in Rez)
            {
                Console.WriteLine(i);
            }
            var Rez1 = Nums.Skip(3);
            foreach (int item in Rez1)
            {
                Console.WriteLine(item);
            }
            var Result = Nums.Skip(4).Take(3);
            foreach (int i in Result)
            {
                Console.WriteLine(i);
            }

            string[] ITEMS = { "Bavaria", "Borusia", "Real Madrid", "Manchester City", "PSJ", "Barecelona" };
            foreach (var t in ITEMS.SkipWhile(x=>x.StartsWith("B")))
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
            List<Phone> heraxosner=new List<Phone>()
                {
    new Phone {Name="Lumia 430", Company="Microsoft" },
    new Phone {Name="Mi 5", Company="Xiaomi" },
    new Phone {Name="LG G 3", Company="LG" },
    new Phone {Name="iPhone 5", Company="Apple" },
    new Phone {Name="Lumia 930", Company="Microsoft" },
    new Phone {Name="iPhone 6", Company="Apple" },
    new Phone {Name="Lumia 630", Company="Microsoft" },
    new Phone {Name="LG G 4", Company="LG" }
};
            var PhoneGrroups = from phone in heraxosner
                               group phone by phone.Company;

            foreach (IGrouping<string,Phone> g in PhoneGrroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                {
                    Console.WriteLine(t.Name);
                    
                }
                Console.WriteLine();
            }

            var PhonsGroup = phones.GroupBy(p => p.Company);

            var PhonesGroup2 = from phone in heraxosner
                               group phone by phone.Company into g
                               select new { Name = g.Key, Count = g.Count() };
            foreach (var group in PhonesGroup2)
            {
                Console.WriteLine("{0}:{1}",group.Name,group.Count);
            }

            var PHonesGrup = heraxosner.GroupBy(p => p.Company)
                .Select(g => new { Name = g.Key, Count = g.Count() });

            var phoneGropus2 = from phone in heraxosner
                               group phone by phone.Company into g
                               select new
                               {
                                   Name = g.Key,
                                   Count = g.Count(),
                                   Phones = from p in g select p
                               };

            foreach (var group in phoneGropus2)
            {
                Console.WriteLine("{0}:{1}",group.Name,group.Count);
                foreach (Phone phone in group.Phones)
                {
                    Console.WriteLine(phone.Name);
                }
                Console.WriteLine();
            }

            var PhonsGroup3 = heraxosner.GroupBy(p => p.Company)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Phones = g.Select(p => p)
                });
        }

    }
}
