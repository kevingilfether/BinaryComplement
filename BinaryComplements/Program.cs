using System;

namespace BinaryComplements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Goal - To take a base 10 integer, find its binary counterpart
			//negate the binary, render it in base 10, and return that sucker

			Console.WriteLine ("Here's a magic trick! Give me a number:");
			int input = int.Parse (Console.ReadLine ());
			int output = Complementer (input);
			Console.WriteLine (output);

		}
		public static int Complementer (int input)
		{
			string binaryInput = Convert.ToString (input, 2);
			string binaryNegate ="";
			foreach (char character in binaryInput) 
			{
				if (character == '1')
					binaryNegate += '0';
				else
					binaryNegate += '1';
			}
			int baseTenified = Convert.ToInt32 (binaryNegate, 10);
			return baseTenified;
		}
	}
}
