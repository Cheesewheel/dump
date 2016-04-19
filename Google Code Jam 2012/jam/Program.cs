using System;

namespace jam
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* System.IO.StreamReader file = new System.IO.StreamReader(@"/home/koen/Downloads/input.in"); */
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\Documenten\GitHub\dump\input.in");

			int length, cases, i = 0, i2 = 0, i3 = 0;
			char c;
			string trans = "test", trans2;
			string[] english =    new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
			string[] googlerese = new string[26] {"y","n","f","i","c","w","l","b","k","u","o","m","x","s","e","v","z","p","d","r","j","g","t","h","a","q"};

			cases = int.Parse(file.ReadLine ());
			string[] input = new string[cases];

			if (cases > 30 || cases < 1) {
				Console.WriteLine ("Invalid amount of cases");
				return;
			}

			while (i < cases) {
				input [i] = file.ReadLine ();
				i++;
			}

			i = 0;

			while (i < cases) {
				length = input [i].Length;
				trans = input [i];
				i2 = 0;

				while (i2 < length) {
					i3 = 0;
					c = trans [i2];
					trans2 = c.ToString ();
                    /*Console.ReadLine();*/

					while (i3 < 26) {
					
						if (trans2.Contains (googlerese [i3])) {
							trans = trans.Remove (i2, 1).Insert (i2, english [i3]);
						}

						i3++;
				    }

                    i2++;
				}

                input[i] = "Case #" + (i + 1) + ": " + trans;
                i++;
			}

			/* System.IO.File.WriteAllLines(@"/home/koen/Documenten/C#/dump/jam/output.txt", input); */
            System.IO.File.WriteAllLines(@"D:\Documenten\GitHub\dump\output.txt", input);
            Console.WriteLine("Done");
            Console.ReadLine();
		}
	}
}
