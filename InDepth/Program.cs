using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InDepth;

namespace delegates
{
    class Program
    {
        static async Task Main(string[] args)
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


            //var dt = new DynamicTyping();
            ////dt.TestDynamic();
            //Action<string> action = (str) => Console.WriteLine(str);
            //dt.Expando();
            //dt.any = action;
            //dt.Any("Mohsen");

            //dt.CallMethods(10);
            //dt.CallMethods("mohsen");

            // 10L is of type long but its convertible to decimal
            //dt.CallMethods(10L);

            //10.1.F is of type float but its not convertible to decimal so it calls the object signature of method
            //dt.CallMethods(10.1F);
            //dt.CallMethods(dt);
            




            /****** Awaitable Test *******/
            //var task = Awaitable.DemoCompletedAsync(); // call the async method
            //Console.WriteLine("Method returned");
            //task.Wait(); // Block until the task completes
            //Console.WriteLine("Task completed");




            /******* Anonymous Async *******/
            // There is no any difference between await and .Result except the exception.
            // the await wrap the exception in AggregateException but the .Result only raise the exception
            //var first = AnonymousAsync.function(5);
            //Task<int> second = AnonymousAsync.function(3);
            //Console.WriteLine("First Result: {0}", await first.ConfigureAwait(false) * await second);
            //Console.WriteLine("Before second");
            //Console.WriteLine("Second Result: {0}", second.Result);
            //Console.WriteLine("After await");





            /*************** foreach in C# 5 ***************/

            List<string> names = new List<string> { "Mohsen", "Ali", "Mohammad" };
            var actions = new List<Action>();
            foreach (var name in names)
            {
                // for each iterate over the names in foreach loop a new variable of name would be generated
                actions.Add(() => Console.WriteLine(name));
            }

            for (int i = 0; i < names.Count - 1; i++)
            {
                // take attention to the warning for the n
                actions.Add(() => Console.WriteLine(names[i]));
            }

            string n;
            using (var iterator = names.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    n = iterator.Current;
                    // take attention to the warning for the n
                    actions.Add(() => Console.WriteLine(n));
                }
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}