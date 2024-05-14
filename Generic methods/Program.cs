


using Generic_methods;
using Microsoft.VisualBasic;
using System.Collections;

class Genric<T>
{
     T box;
    public Genric(T box)
    {
        this.box = box;

    }

    public T Box
    {
        get
        {
            return this.box;
        }

        set
        {
            this.box = value;
        }
    }

}




class Progrm
{
    //static void Main(string[] args)
    //{
    //    Genric<string> genric = new Genric<string>("Noman");
    //    Genric<int> genric1 = new Genric<int>(1);

    //    C//onsole.WriteLine(genric.Box);

    //    genric1.Box = 2;
    //    // Console.WriteLine(genric1.Box);


    //}


    //ListCollection
    //static void Main(string[] args)
    //{
    //    ArrayList myList = new ArrayList();
    //    myList.Add(20);
    //    Console.WriteLine(myList);
    //    Console.WriteLine(myList.Add(myList.Count));
    //    Console.WriteLine( myList.Contains(20));
    //    Console.WriteLine(myList.Add("new"));
    //    foreach (object item in myList)
    //    {
    //        Console.Write(item + " ");
    //    }




    //}

    //Generic List Collection
   static void Main(string[] args)
    {
        
        //List<string> list = new List<string>();
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write("Enter names");
        //    string a = Console.ReadLine();
        //    list.Add(a.ToString());

        //}
        //foreach (string s in list)
        //{
        //    Console.WriteLine(s," ");
        //}

        Employee employee = new Employee();
        employee.name = "Test";
        employee.age = 1;
        employee.desination = "CEO";

        List<Employee> Emplist = new List<Employee>();
        Emplist.Add(employee);
        foreach (Employee s in Emplist)
        {
            Console.WriteLine(s.name + " " );
        }


    }




}
