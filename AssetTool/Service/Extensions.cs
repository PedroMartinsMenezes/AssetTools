namespace AssetTool
{
    public static class Extensions
    {
        #region List
        public static List<T> Resize<T>(this List<T> self, Transfer transfer, long count, bool withNull = false)
        {
            self ??= new();
            if (transfer.IsReading)
            {
                if (count == 0)
                    return self;
                if (count > AppConfig.MaxArraySize)
                    throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");

                for (int i = 0; i < count; i++)
                {
                    self.Add(withNull ? default : Activator.CreateInstance<T>());
                }
            }
            return self;
        }

        public static List<T> Resize<T>(this List<T> self, Transfer transfer, bool withNull = false)
        {
            self ??= new();
            if (transfer.IsReading)
            {
                int count = transfer.reader.ReadInt32();
                if (count > AppConfig.MaxArraySize)
                    throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
                if (count < 0)
                    throw new InvalidOperationException($"Array Size is Negative: {count}");
                Enumerable.Range(0, count).ToList().ForEach(x => self.Add(withNull ? default : Activator.CreateInstance<T>()));
            }
            else
            {
                transfer.writer.Write(self.Count);
            }
            return self;
        }
        #endregion

        public static bool IsFilled(this FName self)
        {
            return self is { } && self.Value is { } && self.Value != "None";
        }
    }
}
