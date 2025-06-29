using System.Globalization;

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

        #region String to Array Conversions
        public static byte[] ToByteArray(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            byte[] numbers = new byte[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = byte.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static Int16[] ToInt16Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            Int16[] numbers = new Int16[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = Int16.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static UInt16[] ToUInt16Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            UInt16[] numbers = new UInt16[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = UInt16.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static Int32[] ToInt32Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            Int32[] numbers = new Int32[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = Int32.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static UInt32[] ToUInt32Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            UInt32[] numbers = new UInt32[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = UInt32.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static Int64[] ToInt64Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            Int64[] numbers = new Int64[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = Int64.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static UInt64[] ToUInt64Array(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            UInt64[] numbers = new UInt64[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = UInt64.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static float[] ToFloatArray(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            float[] numbers = new float[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = float.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }

        public static double[] ToDoubleArray(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            double[] numbers = new double[count];
            int index = 0;
            while (!span.IsEmpty)
            {
                int spaceIndex = span.IndexOf(' ');
                ReadOnlySpan<char> part;
                if (spaceIndex == -1)
                {
                    part = span;
                    span = ReadOnlySpan<char>.Empty;
                }
                else
                {
                    part = span.Slice(0, spaceIndex);
                    span = span.Slice(spaceIndex + 1);
                }
                numbers[index++] = double.Parse(part, CultureInfo.InvariantCulture);
            }
            return numbers;
        }
        #endregion
    }
}
