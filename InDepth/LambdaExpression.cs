using System;
using System.Collections.Generic;
using System.Text;

namespace delegates
{
    class LambdaExpression
    {
        public List<Action> createActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                string text = string.Format("Message {0}", i);
                actions.Add(() => Console.WriteLine(text));
            }

            return actions;
        }
    }
}
