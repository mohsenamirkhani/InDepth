using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InDepth
{
    public class IndexerInObjectInitializer<T>
        : IEnumerable<KeyValuePair<string, T>>
    {
        private readonly IDictionary<string, T> properties = new Dictionary<string, T>();


        public string Key { get; set; }
        public string ParentKey { get; set; }

        public T this[string index]
        {
            get => properties[index];
            set => properties[index] = value;
        }

        public void Add(string propertyKey, T value)
        {
            properties.Add(propertyKey, value);
        }

        public IEnumerator<KeyValuePair<string, T>> GetEnumerator() => properties.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            string formattableString = "";
            foreach (var property in properties)
            {
                formattableString += $"{property.Key}: {property.Value}\n";
            }
            return $"properties:\n{formattableString} key: {Key}, parentKey: {ParentKey}\n";
        }
    }
}
