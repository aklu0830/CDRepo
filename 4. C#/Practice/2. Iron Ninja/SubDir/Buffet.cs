using System;
using System.Collections.Generic;

namespace aklusa.SubDir {
    class Buffet {
        public List<IConsumable> Menu;

        public Buffet() {
            Menu = new List<IConsumable>() {
                new Food("Pizza", 800, false, false),
                new Food("Ice Cream", 950, true, false),
                new Food("Asparagus", 80, false, false),
                new Food("Burrito", 600, false, true),
                new Food("Crab Legs", 100, false, false),
                new Drink("Milkshake", 800, false),
                new Drink("Soda", 300, false),
                new Drink("Lemon Squeeze", 30, true)
            };
        }

        public IConsumable Serve() {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }
    }
}