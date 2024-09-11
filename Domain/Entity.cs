using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEnemyFight.Domain
{
    class Entity
    {
        public string name;
    }

    class Enemy : Entity
    {
        public int basedamage;
        public int hp;
        public Weapons? weapon; //krejzy nepovinny parametr
        public int maxHp;

        public Enemy(string name, int basedamage, int hp, Weapons? weapon = null)
        {
            this.name = name;
            this.basedamage = basedamage;
            this.hp = hp;
            this.weapon = weapon;
            this.maxHp = hp;
        }

        public void Attack(Enemy enemy)
        {
            enemy.hp -= this.basedamage + (int)(weapon ?? 0);
            if (this.basedamage > enemy.hp)
            {
                enemy.hp = 0;
            }
        }

        public void Heal(Potions potions)
        {
            if (this.hp + (int)potions > this.maxHp)
            {
                Console.WriteLine($"{name} se nemohl vyhealovat potionem, protože má plný počet Hp");
            }
            else
            {
                this.hp += (int)potions;
                Console.WriteLine($"{name} se healnul potionem {potions} (+{(int)potions}Hp)");
            }
        }
        public bool isliving
        {
            get
            {
                return this.hp > 0;
            }
        }


        public override string ToString()
        {
            return $"Enemy se jmenuje: {this.name}, jeho basedamage je: {this.basedamage}, jeho hp jsou: {this.hp}, status nepřítele: {isliving}";
        }
    }

    public enum Potions
    {
        Small = 5,
        Mid = 7,
        Large = 12
    } 
    
    public enum Weapons
    {
        Dagger = 1,
        Sword = 2,
        Spear = 3,
    }

}