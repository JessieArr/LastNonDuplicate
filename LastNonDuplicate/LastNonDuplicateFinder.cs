using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNonDuplicate
{
	public class LastNonDuplicateFinder
	{
		public char FindLastNonDuplicate(string target)
		{
			if (target == null)
			{
				return '\0';
			}
			var characterDictionary = new Dictionary<char, int>();
			for (var i = 0; i < target.Length; i++)
			{
				var currentChar = target[i];
				if (!characterDictionary.ContainsKey(currentChar))
				{
					characterDictionary.Add(currentChar, 1);
				}
				else
				{
					characterDictionary[currentChar] = characterDictionary[currentChar] + 1;
				}
			}

			for (var i = target.Length - 1; i >= 0; i--)
			{
				var currentChar = target[i];
				if (characterDictionary[currentChar] == 1)
				{
					return currentChar;
				}
			}
			return '\0';
		}
	}
}
