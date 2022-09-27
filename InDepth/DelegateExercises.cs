using System;

namespace delegates
{
    public class DelegateExercises
    {
        public delegate string MyDelegate(string str);

        public string Method1(string str)
        {
            return $"String you passed is: {str}\n";
        }

        public string Method4(string str)
        {
            return $"Method 4 is calling String you passed is: {str}\n";
        }

        public void Method2()
        {
            MyDelegate del = Method1;
            Method3(del);
            del = Method4;
            Method3(del);
        }

        public void Method3(MyDelegate del)

        {
            Console.WriteLine(del("Mohsen"));
            Console.WriteLine(del("Ali"));
        }
    }
}
