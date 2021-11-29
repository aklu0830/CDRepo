using System;
using System.Collections.Generic;
using System.Linq;

namespace Program {
    public class Program {
        
        public static void Main(string[] args) {
            RandomArray(); //Calls RandomArray Function
            TossCoin(); //Calls TossCoin Function
            Names(); // Calls Names Function
            TossMultipleCoins(5); //

        }
        //RandomArray Function
        public static int[] RandomArray() {
            Random random = new Random();
            int[] randArray = new int[10];
            for (int i = 0; i < randArray.Length; i++) {
                randArray[i] = random.Next(5, 25);
                Console.WriteLine(randArray[i] + " ");
            }

            return randArray;
        }
        
        //TossCoin Function
        public static string TossCoin() {
            string result = "j";
            Random random = new Random();
            
            string[] possibleRes = {"Heads", "Toes"};
            Console.WriteLine("Tossing A Coin");
            result = possibleRes[random.Next(0, possibleRes.Length)];
            Console.WriteLine(result);
            return result;
        }
        
        //TossMultipleCoins Function
        public static double TossMultipleCoins(int num) {
            double heads = 0.0;
            double toes = 0.0;
            double total = 0.0;
            
            
            for (int i = 0; i < num; i++) {
                string result = TossCoin();
                if (result.Equals("Heads")) {
                    heads++;
                    total++;
                } else if (result.Equals("Toes")) {
                    toes++;
                    total++;
                }
            }

            double rez = total/heads;
            Console.Write(rez);
            return rez;
        }
        
        //Names Function
        public static List<string> Names() {
            Random random = new Random();
            List<string> li = new List<string>();
            List<string> lie = new List<string>();
            li.Add("Todd");
            li.Add("Tiffany");
            li.Add("Charlie");
            li.Add("Geneva");
            li.Add("Sydney");
            
            var rnd = new Random();
            List<string> ShuffledList = new List<string>();
            var randomized = li.OrderBy(item => rnd.Next());
            foreach (var value in randomized) {
                Console.WriteLine(value);
                ShuffledList.Add(value);
            }
            return ShuffledList;
        }
    }
}