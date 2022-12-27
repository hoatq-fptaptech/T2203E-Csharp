using System;
namespace T2203E_CSharp.session4
{
	public class DemoEvent
	{
		public event StringToVoid Print;
		public event StringToVoid Action;
		public event StringToVoid Touch;
        public event StringToVoid Swipe;

        public DemoEvent()
		{
			Print += DemoDelegate.SayHello;
			Print += new DemoDelegate().ShowInfo;
		}

		public void Invoke()
		{
			Print("Hello world!");
		}

	}
}

