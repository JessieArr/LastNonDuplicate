using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNonDuplicate
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please input a string. We will display the last non duplicate character");
			var input = Console.ReadLine();
			var tester = new LastNonDuplicateFinder();
			var lastNonDuplicate = tester.FindLastNonDuplicate(input);
			if (lastNonDuplicate == '\0')
			{
				Console.WriteLine("No non-duplicated characters found!");
			}
			else
			{
				Console.WriteLine("We found that this was the last character that only appears once: " + lastNonDuplicate);
			}
			Console.ReadLine();
		}
	}
}
