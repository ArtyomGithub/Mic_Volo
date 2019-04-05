using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Mic.Volo.LINQJoin
{
    class Program
    {
        static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = new BigInteger(0);
            BigInteger b = new BigInteger(1);
            BigInteger c = new BigInteger(0);
           
            while (Console.ReadKey().Key==ConsoleKey.Spacebar)
            {
                yield return c;
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>()
            {
                new Team{Name="Bavaria",Country="Germany"},
                new Team{Name="Barcelona",Country="Espany"},
            };
            List<Player> players = new List<Player>()
            {
                new Player{Name="Mecci",Team="Barcelona"},
                new Player{Name="Neimar",Team="Barcelona"},
                new Player{Name="Robben",Team="Bavaria"},
            };
            var result = from pl in players
                         join t in teams on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            foreach (var item in result)
            {
                Console.WriteLine("{0}-{1} ({2})", item.Name, item.Team, item.Country);
            }
            var result1 = players.Join(teams, p => p.Team, t => t.Name,
                (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });
            var result2 = teams.GroupJoin(players,
                t => t.Name,
                pl => pl.Team,
                (team, pls) => new
                {
                    Name = team.Name,
                    Country = team.Country,
                    Players = pls.Select(p => p.Name)
                });

            foreach (var team in result2)
            {
                Console.WriteLine(team.Name);
                foreach (string player in team.Players)
                {
                    Console.WriteLine(player);
                }
                Console.WriteLine();
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
            IEnumerable<BigInteger> g = Fibonacci();
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }


                }
    }
}
