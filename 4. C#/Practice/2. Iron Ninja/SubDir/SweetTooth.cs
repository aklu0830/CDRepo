using System;

namespace aklusa.SubDir {
    class SweetTooth : Ninja {
        public override bool IsFull {
            get { return calorieIntake < 1500; }
        }

        public override void Consume(IConsumable item) {
            if (IsFull) {
                Console.WriteLine("I'm Full");
                return;
            }

            int newCalories = item.isSweet ? item.calories + 10 : item.calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}