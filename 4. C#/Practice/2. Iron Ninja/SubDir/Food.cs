namespace aklusa.SubDir {
    public class Food : IConsumable {
        public string name { get; set; }
        public int calories { get; set; }
        public bool isSpicy { get; set; }
        public bool isSweet { get; set; }
        
        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet) {
            name = Name;
            calories = Calories;
            isSpicy = IsSpicy;
            isSpicy = IsSweet;

        }

        public void sliceInHalf() {
            calories = calories / 2;
        }

        public string GetInfo() {
            return $"{name} (Food), Calories: {calories}. Spicy?: {isSpicy}. Sweet?: {isSweet} ";
        }
    }
}