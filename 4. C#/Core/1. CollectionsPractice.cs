using System;
using System.Collections.Generic;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            int[] ZeroToNine = new int[10];
            //Create an array holding values 0-9;
            for (int i = 0; i < ZeroToNine.Length; i++) {
                ZeroToNine[i] = i;
                Console.WriteLine(ZeroToNine[i]);
            }

            Console.WriteLine("");

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Blueberry");
            flavors.Add("Fork");
            Console.WriteLine("List of flavors is: " + flavors.Count);
            Console.WriteLine("Flavor 3 is: " + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("New Length: " + flavors.Count);
            Boolean[] s = {true, false, false, true, true, false, true, true, false, false};
            Random random = new Random();
            Dictionary<string, string> profile = new Dictionary<string, string>();
            for (int i = 0; i < names.Length; i++) {
                profile.Add(names[i], flavors[random.Next(flavors.Count)]);
            }

            foreach (KeyValuePair<string, string> entry in profile) {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}