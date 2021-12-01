using System;

namespace aklusa.SubDir {
    class SpiceHound : Ninja {
        public override bool IsFull {
            get { return calorieIntake < 1500; }
        }

        public override void Consume(IConsumable item) {
            if (IsFull) {
                Console.WriteLine("I am full");
                return;
            }

            int newCalories = item.isSweet ? item.calories + 10 : item.calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}