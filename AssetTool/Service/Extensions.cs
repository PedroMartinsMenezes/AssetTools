using System.Reflection;

namespace AssetTool
{
    public static class Extensions
    {
        public static List<T> Resize<T>(this List<T> self, int count) where T : new()
        {
            self ??= new();
            if (count == 0)
                return self;
            Enumerable.Range(0, count).ToList().ForEach(x => self.Add(new()));
            return self;
        }

        public static List<T> Resize<T>(this List<T> self, Transfer transfer, bool withNull = false) where T : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                int count = transfer.reader.ReadInt32();
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(withNull ? default : new()));
            }
            else
            {
                transfer.writer.Write(self.Count);
            }
            return self;
        }

        public static Dictionary<T1, T2> Resize<T1, T2>(this Dictionary<T1, T2> self, int count) where T1 : new() where T2 : new()
        {
            self ??= new();
            if (self.Count == 0 && count > 0)
            {
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(new(), new()));
            }
            return self;
        }

        public static Dictionary<T1, T2> Resize<T1, T2>(this Dictionary<T1, T2> self, Transfer transfer) where T1 : new() where T2 : new()
        {
            self ??= new();
            if (transfer.IsReading)
            {
                int count = transfer.reader.ReadInt32();
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(new(), new()));
            }
            else
            {
                transfer.writer.Write(self.Count);
            }
            return self;
        }

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
