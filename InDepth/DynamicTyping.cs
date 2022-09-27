using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace delegates
{
    class DynamicTyping
    {
        public void TestDynamic()
        {
            dynamic text = "Some Random String";

            // the methods wont be checked in compile time
            string subStr = text.Substring(6);
            Console.WriteLine(subStr);

            // this would throw Exception in run time
            // RuntimeBinderException
            subStr = text.SUBSTR(6);
            Console.WriteLine(subStr);
        }
        
        public void CallMethods(dynamic var)
        {
            //Console.WriteLine(var is int i ? i : 0);
            SampleMethod(var);
        }

        private void SampleMethod(int var)
        {
            Console.WriteLine($"It Is Integer {var}");
        }

        private void SampleMethod(string var)
        {
            Console.WriteLine($"This is String {var}");
        }

        private void SampleMethod(decimal var)
        {
            Console.WriteLine($"decimal method {var}");
        }

        private void SampleMethod(object var)
        {
            string varName = var.GetType().Name;
            Console.WriteLine($"this one is for dynamic {varName}");
        }

        // NOTE: this method signature has overlap with the object signature
        //private void SampleMethod(dynamic var)
        //{

        //}

        public void Expando()
        {
            dynamic expando = new ExpandoObject();
            Action<string> action = (str) => Console.WriteLine(str);
            expando.Any = action;
            expando.Any("Amirkhani");

        }
    }
}
