using System;
using System.Threading.Tasks;

namespace NetCoreConsoleApp
{
    class Program
    {
         static async Task  Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await foreach(Employee emp in EmployeeGenerator.GetEmployees())
            {
                Console.WriteLine(emp);
            }
        }
    }
}
