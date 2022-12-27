using System;
namespace T2203E_CSharp.session4
{
	public delegate void StringToVoid(string s);

	public class DemoDelegate
	{
		public DemoDelegate()
		{
		}

		public void ShowInfo(string s)
		{
			Console.WriteLine("Hello " + s);
		}

		public static void SayHello(string str)
		{
			Console.WriteLine("Say: "+str);
		}
	}
}

