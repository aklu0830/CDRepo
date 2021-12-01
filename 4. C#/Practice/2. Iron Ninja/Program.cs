using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using aklusa.SubDir;


namespace aklusa {
    public class Program {
        public static void Main(string[] args) 
        {
            Buffet buffet = new Buffet();
            SpiceHound sh = new SpiceHound();
            SweetTooth st = new SweetTooth();

            while(!sh.IsFull)
                sh.Consume(buffet.Serve());
            
            while(!st.IsFull)
                st.Consume(buffet.Serve());

            Ninja winner;
            string title;
            if(sh.ConsumptionHistory.Count > st.ConsumptionHistory.Count)
            {
                winner = sh;
                title = "Spice Hound";

            }
            else
            {
                winner = st;
                title = "Sweet Tooth";

            }

            Console.WriteLine($"{title} is the winner, with {winner.ConsumptionHistory.Count} items consumed!");

            
        }
    }
}