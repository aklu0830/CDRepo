using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            Samurai s = new Samurai("Alex", 3, 25, 3);
            Wizard w = new Wizard("Fork", 3, 2);
            Ninja n = new Ninja("Nin", 3, 25, 150);
            s.Attack(n);

        }


        public class Human {
            public string Name = "Human";
            public int Strength = 3;
            public int Intelligence = 15;
            public int Dexterity = 125;
            public int health = 140;

            public virtual int getHealth {
                get { return health; }
            }

            public Human(string name) {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }

            public Human(string name, int str, int intel, int dex, int hp) {
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }

            // Build Attack method
            public virtual int Attack(Human target) {
                int dmg = Strength * 3;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }

        public class Wizard : Human {
            public Wizard(string name, int str, int dex) : base(name, str, intel: 25, dex, hp: 50) {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("BF Attack Health" + getHealth(this));

                Console.WriteLine("BF Attack Health" + getHealth(this));
                Console.WriteLine("");
            }

            public override int Attack(Human target) {
                
                target.health -= 5 * Intelligence;
                if (target.health <= 0) {
                    target.health = 0;
                    Console.WriteLine($"{target.Name} has been killed by {Name}");
                }
                else {
                    Console.WriteLine(target.health + " Opponent Health");
                }

                return 1;
            }

            public int getHealth(Human target) {
                return base.getHealth;
            }
        }

        public class Ninja : Human {
            public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, dex: 175, hp) {}


            public override int Attack(Human target) {
                var r = new Random();
                bool rChance = false;
                int tDamage = 4 * Dexterity;

                if (r.Next(0, 4) == 1) {
                    rChance = true;
                }
                else {
                    Console.WriteLine("");
                }


                if (rChance == true) {
                    tDamage += 10;
                    rChance = false;
                }


                target.health -= tDamage;
                Console.WriteLine($"{Name} attacked {target.Name} for {tDamage} damage!");
                if (target.health <= 0) {
                    Console.WriteLine($"{target.Name} has been killed by {Name}");
                    target.health = 0;
                }
                else {
                    Console.WriteLine($"{target.Name} Health remaining: {target.health}");
                }

                return target.health;
            }
        }
        
        public class Samurai : Human {
            public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, hp:200) {
             Console.Write("My Health: " + health);   
            }

            public override int Attack(Human target) {
                base.Attack(target);
                if (target.health < 50) {
                    target.health = 0;
                } else {
                    
                }

                if (target.health <= 0) {
                    Console.WriteLine($"Samurai {Name} has killed {target.Name}");
                    Console.WriteLine($"Remaining Health of {target.Name}: {target.health}");
                    
                }
                return 1;
            }
        }
    }
}