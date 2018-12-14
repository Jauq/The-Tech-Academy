using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee<string>> listEmps = new List<Employee<string>>();
            listEmps.Add(new Employee<string>() { FirstName = "Mark", LastName = "Johnson", ID = 0 });
            listEmps.Add(new Employee<string>() { FirstName = "Joe", LastName = "Simmons", ID = 1 });
            listEmps.Add(new Employee<string>() { FirstName = "Hans", LastName = "O'Konnel", ID = 2 });
            listEmps.Add(new Employee<string>() { FirstName = "Travis", LastName = "Scottson-Davis", ID = 3 });
            listEmps.Add(new Employee<string>() { FirstName = "Anna", LastName = "McGebby", ID = 4 });
            listEmps.Add(new Employee<string>() { FirstName = "Lauriel", LastName = "Agnes", ID = 5 });
            listEmps.Add(new Employee<string>() { FirstName = "Joe", LastName = "Hoaks", ID = 6 });
            listEmps.Add(new Employee<string>() { FirstName = "Rebecca", LastName = "Nolanson", ID = 7 });
            listEmps.Add(new Employee<string>() { FirstName = "Fawn", LastName = "Smith", ID = 8 });
            listEmps.Add(new Employee<string>() { FirstName = "Thomas", LastName = "Van Troven", ID = 9 });

            List<Employee<string>> joeList = new List<Employee<string>>();
            foreach(Employee<string> emp in listEmps)
            {
                if (emp.FirstName == "Joe")
                {
                    joeList.Add(emp);
                    emp.SayName();
                }
            }
            Console.ReadLine();

            List<Employee<string>> joeList2 = listEmps.Where(x => x.FirstName == "Joe").ToList();
            joeList2.ForEach(x => x.SayName());
            Console.ReadLine();

            List<Employee<string>> higher5List = listEmps.Where(x => x.ID > 5).ToList();
            higher5List.ForEach(x => x.SayName());
            Console.ReadLine();
        }
    }
}
