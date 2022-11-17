using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InDepth
{
    public class AnonymousAsync
    {
        public static Func<int, Task<int>> function = async x =>
        {
            Console.WriteLine("Starting... x={0}", x);
            await Task.Delay(x * 1000);
            Console.WriteLine("Finished... x={0}", x);

            return x * 2;
        };
    }
}
