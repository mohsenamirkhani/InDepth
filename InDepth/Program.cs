using System;
using System.Collections.Generic;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* USAGE OF POINTER */
            //var delEx = new DelegateExercises();
            //delEx.Method2();

            /* USAGE OF ITERATOR */
            //var example = new EnumerableExample();

            //foreach (var variable in example.CreateEnumerable())
            //{
            //    Console.WriteLine(variable);
            //}

            /* USAGE OF IENUMERABLE */
            //var enumerable = example.CreateEnumerable();
            //using var enumerator = enumerable.GetEnumerator(); //"using" statement without brackets would work fine
            //while (enumerator.MoveNext())
            //{
            //    if (enumerator.Current == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(enumerator.Current);
            //}

            /* USAGE OF LAMBDA EXPRESSION AND Action CLASS */
            //LambdaExpression lm = new LambdaExpression();
            //List<Action> actions = lm.createActions();
            //foreach (var action in actions)
            //{
            //    action();
            //}


            var dt = new DynamicTyping();
            //dt.TestDynamic();
            Action<string> action = (str) => Console.WriteLine(str);
            dt.Expando();
            //dt.any = action;
            //dt.Any("Mohsen");

            //dt.CallMethods(10);
            //dt.CallMethods("mohsen");

            // 10L is of type long but its convertible to decimal
            //dt.CallMethods(10L);

            //10.1.F is of type float but its not convertible to decimal so it calls the object signature of method
            //dt.CallMethods(10.1F);
            //dt.CallMethods(dt);
        }
    }
}
