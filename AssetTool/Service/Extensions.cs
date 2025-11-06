using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace AssetTool
{
    public static class Extensions
    {
        public static bool IsFilled(this FName self)
        {
            return self is { } && self.Value is { } && self.Value != "None";
        }

        public static T[] ToArray<T>(this int count, bool withNull = false) where T : new()
        {
            T[] array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = withNull ? default : new T();
            }
            return array;
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

        public static sbyte[] ToSByteArray(this string input)
        {
            if (input.Length == 0) return [];
            ReadOnlySpan<char> span = input.AsSpan();
            int count = 1;
            for (int i = 0; i < span.Length; i++)
                if (span[i] == ' ') count++;

            sbyte[] numbers = new sbyte[count];
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
                numbers[index++] = sbyte.Parse(part, CultureInfo.InvariantCulture);
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
                numbers[index++] = part.ToFloat();
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
                numbers[index++] = part.ToDouble();
            }
            return numbers;
        }
        #endregion

        #region NaN Numbers
        public static string ToStr(this float self)
        {
            if (!float.IsNaN(self))
            {
                return self.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                return $"0x{BitConverter.ToString(BitConverter.GetBytes(self)).Replace("-", "")}";
            }
        }

        public static float ToFloat(this string self)
        {
            if (!self.StartsWith("0x"))
            {
                return float.Parse(self, CultureInfo.InvariantCulture);
            }
            else
            {
                string hexDigits = self.Substring(2);
                byte[] bytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    bytes[i] = Convert.ToByte(hexDigits.Substring(i * 2, 2), 16);
                }
                return BitConverter.ToSingle(bytes, 0);
            }
        }

        public static float ToFloat(this ReadOnlySpan<char> self)
        {
            if (!self.StartsWith("0x"))
            {
                return float.Parse(self, CultureInfo.InvariantCulture);
            }
            else
            {
                ReadOnlySpan<char> hexDigits = self.Slice(2);
                uint intValue = uint.Parse(hexDigits, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
                return BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0);
            }
        }

        public static string ToStr(this double self, bool isDouble = true)
        {
            if (!double.IsNaN(self))
            {
                return self.ToString(CultureInfo.InvariantCulture);
            }
            else if (isDouble)
            {
                return $"0x{BitConverter.ToString(BitConverter.GetBytes(self)).Replace("-", "")}";
            }
            else
            {
                return $"0x{BitConverter.ToString(BitConverter.GetBytes((float)self)).Replace("-", "")}";
            }
        }

        public static double ToDouble(this ReadOnlySpan<char> self)
        {
            if (!self.StartsWith("0x"))
            {
                return double.Parse(self, CultureInfo.InvariantCulture);
            }
            else
            {
                ReadOnlySpan<char> hexDigits = self.Slice(2);
                if (hexDigits.Length / 2 == 8)
                {
                    ulong intValue = ulong.Parse(hexDigits, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
                    return BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0);
                }
                else
                {
                    uint intValue = uint.Parse(hexDigits, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
                    return BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0);
                }
            }
        }
        #endregion

        #region String
        public static string SmartTrim(this string self)
        {
            int a = self.IndexOf('\'');
            int b = self.LastIndexOf('\'');
            return self.Substring(a + 1, b - a - 1);
        }

        public static string NameOnly(this string self)
        {
            return Path.GetFileNameWithoutExtension(self);
        }

        public static string NameWithExtension(this string self)
        {
            return Path.GetFileName(self);
        }


        public static string GetTempJsonPath(this string self)
        {
            var root = Path.GetPathRoot(self);
            var ext = Path.GetExtension(self);
            self = Path.GetFullPath(self).Replace(root, "").Replace(ext, ".json");
            var path = Path.Combine(root, "Temp", "Json", self);
            return path;
        }

        public static string GetTempAssetPath(this string self)
        {
            var root = Path.GetPathRoot(self);
            self = Path.GetFullPath(self).Replace(root, "");
            var path = Path.Combine(root, "Temp", "Asset", self);
            return path;
        }

        public static string Hash(this string self)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(self));
                StringBuilder builder = new();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion
    }
}
