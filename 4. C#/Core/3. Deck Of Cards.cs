using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            int[] vals = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            Deck deck = new Deck();
            deck.shuffle(vals);
        }

        public class Card {
            public string[] cardsArray = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            public string[] suitArray = {"Clubs", "Spades", "Hearts", "Diamonds"};
            public int[] vals = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        }

        public class Deck {
            public int[] shuffle(int[] array) {
                Random rnd = new Random();
                array = array.OrderBy(x => rnd.Next()).ToArray();
                for (int i = 0; i < array.Length; i++) {
                    Console.Write(array[i] + ", ");
                }

                return array;
            }
        }

        public class Player {}
    }
}