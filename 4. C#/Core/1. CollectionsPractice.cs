using System;

namespace Program{
	
	
	public class Program{
		
		public static void Main(string[] args) {
			int[] ZeroToNine = new int[10];
			//Create an array holding values 0-9;
			for(int i = 0; i<ZeroToNine.Length; i++) {
				ZeroToNine[i] = i;
				Console.WriteLine(ZeroToNine[i]);
			}
			string[] names = {"Tim","Martin","Nikki","Sara"};
			Console.WriteLine(names);
			
			
		}
		
	}

}