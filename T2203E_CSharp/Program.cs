using T2203E_CSharp.session1;
using T2203E_CSharp.session3;
using T2203E_CSharp.contact;
using T2203E_CSharp.session4;
using T2203E_CSharp.session5;

public class Program
{
    static void Main(string[] args)
    {
        Fetch();
    }

    static async void Fetch()
    {
        CallApi ca = new CallApi();
        Product s = await ca.FetchData();
        Console.WriteLine(s.ToString());
    }

    static void Main6(string[] args)
    {
        //ThreadRun();
        //Thread t1 = new Thread(ThreadRun);
        //Thread t2 = new Thread(ThreadRunParam);
        //t2.IsBackground = true;
        ////t1.IsBackground = true;
        //t1.Start();
        //t2.Start("T2203E");

        Number num = new Number() { X = 0, Y = 0 };
        Thread n1 = new Thread(ThreadLock);
        Thread n2 = new Thread(ThreadLock);
        n1.Start(num);
        n2.Start(num);
    }

    static void ThreadLock(object o)
    {
        Number n = (Number)o;
        for(int i = 0; i < 20; i++)
        {
            lock (n)
            {
                n.ChangeXY();
                n.PrintXY();
            }
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }

    static void ThreadRun()
    {
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("i=" + i);
            try
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }
    }

    static void ThreadRunParam(object msg)
    {
        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine("i=" + i+" Msg:"+msg);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }

    static void Main5(string[] args)
    {
      
        StringToVoid stv = new StringToVoid(ShowMessage);
        StringToVoid stv2 = new StringToVoid(DemoDelegate.SayHello);
        StringToVoid stv3 = new StringToVoid(new DemoDelegate().ShowInfo);

        stv += DemoDelegate.SayHello;
        stv += new DemoDelegate().ShowInfo;

        stv += stv3;

        stv("Xin chao cac ban");// ShowMessage("Xin chao cac ban");

        DemoEvent de = new DemoEvent();
        de.Invoke();


    }

    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static string GetMessage(string s)
    {
        return "Hello: " + s;
    }


    static void Main4(string[] args)
    {
        PhoneBook pb = new PhoneBook();
        pb.InsertPhone("Nam", "0987272727");
        pb.InsertPhone("Minh", "0123456789");
        pb.InsertPhone("Dung", "09192838211");
        pb.InsertPhone("Nam", "089928291");
        pb.InsertPhone("Nam", "0987272727");

        pb.Sort();

        foreach(PhoneNumber p in pb.PhoneList)
        {
            Console.WriteLine(p.ToString());
        }
    }

    static void Main3(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception("Y Bang 0 Mat roi");
            y++;
            float z = x / y;
            Console.WriteLine("z = " + z);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {

        }
    }

    static void Main2(string[] args) 
    {
        Human h = new Human();
        h.Run();
        Human dvt = new Human();
        dvt.Run();
        h.Age = 19;
        h.Email = "abc@gmail.com";
        //Console.WriteLine(h.Age);

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