using System;
using System.Collections.Generic;
using System.Linq;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            Human Jacob = new Human("Jacob");
            Human.Attack(Jacob, 3);
            Console.WriteLine(Human.getHealth(Jacob));
        }


        public class Human {
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            public int Health;

            public Human() {
                Name = "Alex";
                Strength = 3;
                Intelligence = 9;
                Dexterity = 1;
                Health = 90;

            }
            
            public Human(string name) {
                Name = name;
                Strength = 4;
                Intelligence = 9;
                Dexterity = 1;
                Health = 100;

            }

            public Human(string name, int strength, int intelligence, int dexterity, int health) {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                Health = health;
            }

            public static int getHealth(Human person) {
                return person.Health;
            }
            
            public static int Attack(Human target, int damage) {
                if (getHealth(target)-damage<0) {
                    target.Health = 0;
                    Console.WriteLine("Target has been murdered by powerful weapon");
                } else if (target.Health == 0) {
                    Console.WriteLine("Target is currently dead");
                }
                else {
                    target.Health -= 5*target.Strength;
                    Console.WriteLine("Target health is now " + getHealth(target));
                }

                return 0;
            }
        }
    }
}