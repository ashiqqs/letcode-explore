using HackerrankSolution.InterviewPreparationKit;
using HackerrankSolution.InterviewPreparationKit.DictionaryHashmaps;
using HackerrankSolution.Leetcode;
using HackerrankSolution.Leetcode.ArrayString;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class Customer {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { Name = "Emma", Age = 25 });
            customers.Add(new Customer { Name = "Jane", Age = 25 });
            customers.Add(new Customer { Name = "Jacob", Age = 25 });
            var query = customers.Where(c => c.Age > 30);
            // Modify the data source after creating the query
            customers.Add(new Customer { Name = "John", Age = 35 });
            // Iterate over the query results
            foreach (var customer in query.ToList())
            {
                Console.WriteLine(customer.Name);
            }


            Console.ReadKey();
        }


        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return gcd(b%a,a);
        }
    }

    public class A
    {
        public A()
        {
            Console.WriteLine("Class A");
        }
    }

    public class B: A
    {
        public B()
        {
            Console.WriteLine("Class B");
        }
    }
}
