using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using InDepth;
using static System.FormattableString;

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

            //List<string> names = new List<string> { "Mohsen", "Ali", "Mohammad" };
            //var actions = new List<Action>();
            //foreach (var name in names)
            //{
            //    // for each iterate over the names in foreach loop a new variable of name would be generated
            //    actions.Add(() => Console.WriteLine(name));
            //}

            //for (int i = 0; i < names.Count - 1; i++)
            //{
            //    // take attention to the warning for the n
            //    actions.Add(() => Console.WriteLine(names[i]));
            //}

            //string n;
            //using (var iterator = names.GetEnumerator())
            //{
            //    while (iterator.MoveNext())
            //    {
            //        n = iterator.Current;
            //        // take attention to the warning for the n
            //        actions.Add(() => Console.WriteLine(n));
            //    }
            //}

            //foreach (var action in actions)
            //{
            //    action();
            //}





            /***********************  Expression Bodied  **************************/

            //ExpressionBodied.GetMyName("Mohsen");

            //var exp1 = new ExpressionBodied(1, 2);

            //var exp2 = new ExpressionBodied(3, 4);

            //var result = exp1 + exp2;

            //Console.WriteLine(result);
            //Console.WriteLine(exp1[1]);

            //var list = new List<int> { 1, 2, 3 };
            //var listView = new ReadOnlyListView<int>(list);

            //Console.WriteLine(listView[2]);


            /************** String Format and Alignment *****************/

            //Console.WriteLine("{0, -11}{1}", "----------", "1");

            //var price = 95.25m;
            //var tip = price * 0.2m;
            //// 11 points to right from the starting of opening '{'
            //Console.WriteLine("Price: {0,11:C}", price);
            //Console.WriteLine("Tip:   {0,11:C}", tip);
            //Console.WriteLine("Total: {0,11:C}", price + tip);

            //Console.WriteLine($"Price: {price,11:C}");
            //Console.WriteLine($"Tip:   {tip,11:C}");
            //Console.WriteLine($"Total: {price + tip,11:C}");

            // Interpolation and verbatim
            // Interpolation would exactly convert to string.Format in IL
            //            Console.WriteLine($@"Price: {price,11:C}
            //Tip:   {tip,11:C}
            //Total: {price + tip,11:C}");


            //            var culture = CultureInfo.GetCultureInfo("fa-IR");
            //            var date = new DateTime(1992, 6, 29);
            //            var str = string.Format(CultureInfo.InvariantCulture, "My BirthDay is {0:d}", date);
            //            Console.WriteLine(str);

            //            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            //foreach (var cultureInfo in cultures)
            //{
            //    var priceStr = string.Format(cultureInfo, "Price: {0:C}\n", price);
            //    Console.WriteLine(priceStr);
            //    var c = string.Format(cultureInfo, "{0,-15} {1,12:d}", cultureInfo.Name, date);
            //    Console.WriteLine(c);
            //}


            //var verbatim = @"Hello The ""Date"" is";
            //Console.WriteLine(verbatim.ToString(culture));

            //var invariantFormattableString = FormattableString.Invariant(@$"{verbatim} {date}");

            //var result = $"The result is {invariantFormattableString}";
            //Console.WriteLine(result);

            //var name = "mohsen";
            //var age = 30;

            //FormattableString formattable = $"Hello My Name is {name} and my age is {age}";

            //foreach (var argument in formattable.GetArguments())
            //{
            //    Console.WriteLine(argument);
            //}


            //var alignment = Console.ReadLine();
            //var price = 12d;
            //// As the book said "This isn't code I'd want to either write or read
            //Console.WriteLine($"Price: {{0,{alignment}:C}}", price);









            /***************** Indexers and Object initializer *******************/

            //var text = "This Is A Text To Truncate";

            //var stringBuilder = new StringBuilder(text)
            //{
            //    Length = 8,
            //    [7] = '\u2026'
            //};
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(stringBuilder);

            //// With Collection initializer this code would throw an Exception 
            //// 'An item with the same key has already been added. Key: B'
            //var collectionInitializer = new Dictionary<string, int>()
            //{
            //    { "A", 10 },
            //    { "B", 20 },
            //    { "B", 30 }
            //};


            //// In DICTIONARY with object initializer the 'B' key would overwrites
            //var objectInitializer = new Dictionary<string, int>()
            //{
            //    ["A"] = 10,
            //    ["B"] = 20,
            //    ["B"] = 30
            //};

            //Console.WriteLine(objectInitializer["A"]);
            //Console.WriteLine(objectInitializer["B"]);


            //use the Add method of the class to be able to add members as COLLECTION initializer
            var indexerCollectionInitializer = new IndexerInObjectInitializer<int>
            {
                { "mohsen", 20 },
                { "Narges", 30 }
            };
            indexerCollectionInitializer.Key = "ss";

            Console.Write(indexerCollectionInitializer);


            // but defining indexer and using it in OBJECT initializer we can add initiation for other properties too.
            var indexerObjectInitializer = new IndexerInObjectInitializer<int>
            {
                ["mohsen"] = 10,
                ["narges"] = 30,
                Key = "30",
                ParentKey = indexerCollectionInitializer.Key
            };

            Console.WriteLine(indexerObjectInitializer);
        }
    }
}