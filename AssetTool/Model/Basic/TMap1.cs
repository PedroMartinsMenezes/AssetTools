using System.Collections;
using System.Text.Json;

namespace AssetTool
{
    public class TMap1<Key1, Value> : IDictionary
    {
        public Dictionary<string, Value> Map = new();

        public object this[object key] { get => Map[key.ToString()]; set => Map[key.ToString()] = ((JsonElement)value).Deserialize<Value>(); }

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        public ICollection Keys => Map.Keys;

        public ICollection Values => Map.Values;

        public int Count => Map.Count;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(object key, object value)
        {
            Map.Add(key.ToString(), (Value)value);
        }

        public void Clear()
        {
            Map.Clear();
        }

        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return Map.GetEnumerator();
        }

        public void Remove(object key)
        {
            Map.Remove(key.ToString());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
