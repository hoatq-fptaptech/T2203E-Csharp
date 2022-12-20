using System;
namespace T2203E_CSharp.session1
{
	public  class Human
	{
		private string name;
		private int age;

		private int id;

		public static int xyz;

		public Human()
		{

		}

		public Human(string s)
		{
			this.name = s;
		}


		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public string Name
		{
			get => name;
			set => name = value;
		}

		public int Age
		{
			get => age;
			set => age = value;
		}

		public string Email { get; set; }

		public void Run()
		{
			Console.WriteLine("Running....");
			this.name = "Do Van Thang";
		}

		public void Run(string s)
		{
			// viet gi thi viet
		}

		public  void ScreenShot()
		{

		}

		public virtual void Eat()
		{

		}
	}
}

