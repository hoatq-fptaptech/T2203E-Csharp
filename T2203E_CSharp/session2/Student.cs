using System;
namespace T2203E_CSharp.session1
{
	public class Student : Human
	{
		private string[] telephone = new string[3];

		public Student()
		{
		}

		public Student(string s,int a): base(s)
		{   
			this.Age = a;
		}

		public string this[int index] // indexer
		{
			get => telephone[index];
			set => telephone[index] = value;
		}

		public  void Study()
		{
			base.Run();
			this.Run();
		}

        public override void Eat()
        {
            
        }


    }

}

