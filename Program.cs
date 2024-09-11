using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEnemyFight.Domain;

namespace SimpleEnemyFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy franta = new Enemy("Franta", 5, 10, Weapons.Sword);
            Enemy pepa = new Enemy("Pepa", 20, 40);

            pepa.Attack(franta);
            Console.WriteLine(franta);
            Console.WriteLine(pepa);

            Console.ReadKey();
        }
    }
}
