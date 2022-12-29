using System;
namespace T2203E_CSharp.session5
{
	public class Number
	{
		public int X { get; set; }
		public int Y { get; set; }

		public void ChangeXY()
		{
			X++;
			Y++;
		}

		public void PrintXY()
		{
			Console.WriteLine("X = " + X);
			Console.WriteLine("Y = " + Y);
		}
	}
}

