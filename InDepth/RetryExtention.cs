using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InDepth.Retry
{
    public static class RetryExtension
    {
        public static T Retry<T>(this Func<T> function, int attempts)
        {
            while (true)
            {
                try
                {
                    attempts--;
                    return function();
                }
                catch (Exception ex)
                    when (attempts > 0)
                {
                    Console.WriteLine($"Failed: {ex}");
                    Console.WriteLine($"Attempts left: {attempts}");
                    Task.Delay(500);
                }
            }
        }
    }
}
