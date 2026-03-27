using System;

namespace variable
{
	class example
	{
		static void Main(string[] args)
		{
			int age = 17; // Integer = 4 Byts
			Console.WriteLine("The Age : " + age);

			float num  = 3.14f; // Floating Number = 4 Bytes
			Console.WriteLine("Pi Value : " +  num);

			char Letter = 'C'; // A Character
			Console.WriteLine("A Letter : " + Letter);

			bool true_or_false = true; // True Or False
			Console.WriteLine("Weather Rainy : " + true_or_false);

			string full_name = "Chaitanya Ramesh Kasved"; // String (Group of Characters)
			Console.WriteLine("Name : " + full_name);

			long big_number = 21062008000000; // long > int
			Console.WriteLine("Random Number : " + big_number);

			double large_num = 343.29392923949; // double > float
			Console.WriteLine("Random Number : " + large_num );
		}
	}
}
