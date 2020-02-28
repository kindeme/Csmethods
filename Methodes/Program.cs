using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer("flore", "xevosa");
            C1.PrintFullName();
            Console.ReadLine();
        }
        
    }
}
class Customer
{
    string firstName;
    string lastName;
    // cConstructor with default values
    public Customer()
        : this("No first NAme provided", "No lastname provided")
    {
    }

    //Constructor
    public Customer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this.firstName + " " + this.lastName);
    }
    ~Customer()
    {
        // clean up code
    }
}
