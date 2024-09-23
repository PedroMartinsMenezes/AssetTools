using System.Reflection;

namespace AssetTool
{
    public static class Extensions
    {
        #region List
        public static List<T> Resize<T>(this List<T> self, Transfer transfer, int count, bool withNull = false) where T : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                if (count == 0)
                    return self;
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(withNull ? default : new()));
            }
            return self;
        }

        public static List<T> Resize<T>(this List<T> self, Transfer transfer, bool withNull = false) where T : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                int count = transfer.reader.ReadInt32();
                if (count > AppConfig.MaxArraySize)
                    throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(withNull ? default : new()));
            }
            else
            {
                transfer.writer.Write(self.Count);
            }
            return self;
        }

        public static List<T> Move<T>(this List<T> self, Transfer transfer, Action<T> action) where T : new()
        {
            self ??= new();
            self.Resize(transfer);
            self.ForEach(item => action(item));
            return self;
        }

        public static List<T> MoveWhile<T>(this List<T> self, Transfer transfer, Func<bool> condition, Action<T> action) where T : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                while (condition())
                {
                    T item = new T();
                    action(item);
                    self.Add(item);
                }
            }
            else
            {
                self.ForEach(item => action(item));
            }
            return self;
        }
        #endregion

        #region Dictionary
        public static Dictionary<T1, T2> Resize<T1, T2>(this Dictionary<T1, T2> self, int count) where T1 : new() where T2 : new()
        {
            self ??= new();
            if (self.Count == 0 && count > 0)
            {
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(new(), new()));
            }
            return self;
        }

        public static Dictionary<T1, T2> Resize<T1, T2>(this Dictionary<T1, T2> self, Transfer transfer, int count = 0) where T1 : new() where T2 : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                count = count == 0 ? transfer.reader.ReadInt32() : count;
                if (count > AppConfig.MaxArraySize)
                    throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(new(), new()));
            }
            else
            {
                if (count == 0)
                    transfer.writer.Write(self.Count);
            }
            return self;
        }

        public static Dictionary<T1, T2> Move<T1, T2>(this Dictionary<T1, T2> self, Transfer transfer, Action<T1> act1, Action<T2> act2) where T1 : new() where T2 : new()
        {
            self ??= new();
            self.Resize(transfer);
            foreach (var pair in self)
            {
                act1(pair.Key);
                act2(pair.Value);
            }
            return self;
        }

        public static Dictionary<T1, T2> Move<T1, T2>(this Dictionary<T1, T2> self, Transfer transfer, int count, Action<T1> act1, Action<T2> act2) where T1 : new() where T2 : new()
        {
            self ??= new();
            self.Resize(transfer, count);
            foreach (var pair in self)
            {
                act1(pair.Key);
                act2(pair.Value);
            }
            return self;
        }

        public static Dictionary<T1, T2> Move<T1, T2>(this Dictionary<T1, T2> self, Transfer transfer, Action<T1> act1, Action<T1, T2> act2) where T1 : new() where T2 : new()
        {
            self ??= new();
            self.Resize(transfer);
            foreach (var pair in self)
            {
                act1(pair.Key);
                act2(pair.Key, pair.Value);
            }
            return self;
        }
        #endregion



        public static bool HasAttribute<T>(this FieldInfo self)
        {
            return self is { } && self.GetCustomAttribute(typeof(T)) is { };
        }

        public static int SerializedSize(this string self)
        {
            return self.Length == 0 ? 4 : 5 + self.Length;
        }
    }
}
