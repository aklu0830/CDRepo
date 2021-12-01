namespace aklusa.SubDir {
    public class Drink : IConsumable {
        public string name {get;set;}
        public int calories {get;set;}
        public bool isSpicy {get;set;}
        public bool isSweet {get;set;}

        public Drink(string Name, int Calories, bool IsSpicy) {
            name = Name;
            calories = Calories;
            isSpicy = IsSpicy;
            isSweet = true;
        }

        public string GetInfo() {
            return "";
        }
        
    }
}