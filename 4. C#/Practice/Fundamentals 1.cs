using System;

namespace ConsoleApp {
	public class Program{

	}
	public static void Main(string[] args) {
		//loop 1-255 and print
	for(int i = 1; i<=255; i++) {
		Console.WriteLine(i);
	}
	//loop nums 1-100 that are divisible by 3 or 5 but not both
	for(int i = 1; i<=100; i++) {
		if(i%3==0&&i%5==0){
		} else if(i%3==0||i%5==0) {
			Console.WriteLine(i);
		} else {
			
		}
	}
	//print Fizz for multiples of 3 and Buzz for multiples of 5 and Fizz Buzz for both
		for(int i = 1; i<=100; i++) {
		if(i%3==0&&i%5==0){
			Console.WriteLine("Fizz Buzz");
		} else if(i%3==0) {
			Console.WriteLine("Fizz");
		} else if(i%5==0){
			Console.WriteLine("Buzz");
		} else {
			
		}
	}
}