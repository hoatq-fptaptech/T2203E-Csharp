using System;
namespace T2203E_CSharp.contact
{
	public abstract class Phone
	{
		public abstract void InsertPhone(String name, String phone);

        public abstract void RemovePhone(String name);

        public abstract void UpdatePhone(String name,String oldPhone, String newphone);

        public abstract PhoneNumber SearchPhone(String name);

        public abstract void Sort();

    }

    public class PhoneBook : Phone
    {
        public PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }

        public List<PhoneNumber> PhoneList { get; }


        public override void InsertPhone(string name, string phone)
        {
             foreach(PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (p.Phone.Contains(phone))
                    {
                        return;
                    }
                    p.Phone.Add(phone);
                    return;
                }
            }
            PhoneNumber pn = new PhoneNumber(name, phone);
            PhoneList.Add(pn);
        }

        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((o1, o2) =>
            {
                return o1.Name.CompareTo(o2.Name);
            });  
        }

        public override void UpdatePhone(string name, String oldPhone, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name) && p.Phone.Contains(oldPhone))
                {
                    p.Phone.Remove(oldPhone);
                    p.Phone.Add(newphone);
                    return;
                }
            }
        }
    }
}

