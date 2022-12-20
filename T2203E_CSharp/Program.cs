using T2203E_CSharp.session1;
public class Program
{
    static void Main(string[] args)
    {
        Human h = new Human();
        h.Run();
        Human dvt = new Human();
        dvt.Run();
        h.Age = 19;
        h.Email = "abc@gmail.com";
        Console.WriteLine(h.Age);

        Student s = new Student();
        //   s.telephone[0] = "02982992929";
        s[0] = "092828228";
        s[1] = "02293939393";
        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world");
        ls.Add("morning");

        for(int i = 0; i < ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }

        foreach(string l in ls)
        {
            Console.WriteLine(l);
        }
    }
}