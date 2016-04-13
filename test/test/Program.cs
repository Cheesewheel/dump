using System;

namespace test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string cases;

			System.IO.StreamReader file = new System.IO.StreamReader(@"/home/koen/Downloads/input.in");
			cases = file.ReadLine ();
			Console.WriteLine (cases);
		}
	}
}
