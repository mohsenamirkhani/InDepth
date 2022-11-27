using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InDepth
{
    public class Person : IEnumerable<string>
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<string> Contacts => new List<string>(10);

        public Person Child { get; set; }
        public IEnumerator<string> GetEnumerator() => Contacts.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            var str = new StringBuilder();
            foreach (var contact in Contacts)
            {
                str.Append($"{contact}\n");
            }
            return str.ToString();
        }
    }
}
