using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InDepth
{
    public class Awaitable
    {
        public static async Task DemoCompletedAsync()
        {
            Console.WriteLine("Before first await");

            await Task.FromResult("10"); // Awaits a completed task // The execution flow keep going

            Console.WriteLine("Between awaits");

            await Task.Delay(1000); // Awaits a non-completed task // Does return to the Main method 

            Console.WriteLine("After Second await");
        }
    }
}
