using LinqTasks.Models;

namespace LinqTasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======= ZAD X =======");

        IEnumerable<Object> result = Tasks.Task11();

        foreach (Object emp in result)
        {
            Console.WriteLine(emp);
        }
    }
}