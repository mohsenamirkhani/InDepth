using System;
using System.Collections.Generic;
using System.Text;

namespace delegates
{
    public class EnumerableExample
    {
        public IEnumerable<int> CreateEnumerable()
        {
            try
            {
                Console.WriteLine("Before first yield");
                yield return 10;
                for (var i = 0; i < 10; i++)
                {
                    yield return i;
                }

                yield return 11;
                Console.WriteLine("after last yield");
            }
            finally
            {
                Console.WriteLine("In Finally block");
            }
        }
    }
}
