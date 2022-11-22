using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InDepth
{
    public class ExpressionBodied
    {
        public int Prop1 { get; set; }

        public int Prop2 { get; set; }

        // This is Expression Bodied Method, indexer and operation and is not anonymous function
        public static void GetMyName(string name) => Console.WriteLine($"Hello {name}");

        public static ExpressionBodied operator +(ExpressionBodied i, ExpressionBodied j) => new ExpressionBodied(i.Prop1 + j.Prop1, i.Prop2 + j.Prop2);

        public int this[int index] => Prop1;


        

        // C#7 allow constructor and STATIC constructor to be expression-bodied
        static ExpressionBodied() => Console.WriteLine("Hello From Static Constructor");
        
        public ExpressionBodied(int prop1, int prop2)
        {
            Prop1 = prop1;
        }

        public override string ToString()
        {
            return $"Prop1: {Prop1}\nProp2: {Prop2}";
        }
    }

    public sealed class ReadOnlyListView<T>
    {
        private readonly IList<T> _list;

        public ReadOnlyListView(IList<T> list)
        {
            _list = list;
        }

        public T this[int index] => _list[index];
    }
}
