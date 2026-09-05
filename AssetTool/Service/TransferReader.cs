using System.Runtime.InteropServices;
using System.Text;

namespace AssetTool
{
    public class TransferReader : Transfer
    {
        public TransferReader()
        {
            GlobalObjects.PackageFileSummary = new() { FileVersionUE = new() { FileVersionUE4 = EUnrealEngineObjectUE4Version.VER_UE4_AUTOMATIC_VERSION } };
            GlobalNames.NameToIndex["None"] = 1;

            GlobalObjects.PackageFileSummary.CustomVersionContainer = new();
            GlobalObjects.PackageFileSummary.CustomVersionContainer.Versions = [new() { Key = new(FEditorObjectVersion.Guid), Version = (int)FEditorObjectVersion.Enums.LatestVersion }];
        }

        public TransferReader(BinaryReader reader, AppConfig appConfig)
        {
            this.reader = reader;
            this.AppConfig = appConfig;
            Initialize(this);
            FromJson = false;
            FromAutoCheck = false;
        }

        public override bool IsReading => true;
        public override bool IsWriting => false;
        public override bool FromJson { get; init; }
        public override bool FromAutoCheck { get; init; }
        public override long Position { get { return reader.BaseStream.Position; } set { reader.BaseStream.Position = value; } }
        public override long Length => reader.BaseStream.Length;
        public override long Counter { get; set; }
        public override long BaseOffset { get; set; }
        public override Stream Stream => reader.BaseStream;

        public override void SeekTo(long position) => reader.BaseStream.Seek(position, SeekOrigin.Begin);

        public override void MoveConst(Int32 value) => reader.ReadInt32();

        public override void MoveAsUInt16(ref Int32 value) => value = reader.ReadUInt16();
        public override void MoveAsUInt16(ref Int32? value) => value = reader.ReadUInt16();

        public override void MoveAsByte(ref UInt16 value) => value = reader.ReadByte();
        public override void MoveAsByte(ref UInt16? value) => value = reader.ReadByte();

        public override void MoveAsInt(ref Int64 value) => value = reader.ReadInt32();
        public override void MoveAsInt(ref Int64? value) => value = reader.ReadInt32();

        public override void MoveEnum<T>(ref T value)
        {
            reader.Read(MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan<T>(ref value, 1)));
        }

        public override void MoveEnum<T>(ref T? value)
        {
            T temp = default;
            var span = MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan<T>(ref temp, 1));
            reader.Read(span);
            for (int i = 0; i < span.Length; i++)
            {
                if (span[i] != 0)
                {
                    value = temp;
                    break;
                }
            }
        }

        public override void MoveEnum<T>(ref T[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new T[reader.ReadInt32()]).AsSpan()));
        }

        public override void MoveEnum<T>(ref T[] value, int index)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new T[index]).AsSpan()));
        }

        #region
        public override void MoveFloat(ref double value) => value = reader.ReadSingle();
        public override void MoveFloat(ref double? value) => value = reader.ReadSingle();

        public override void Move(ref bool value) => value = reader.ReadInt32() == 1;
        public override void Move(ref bool? value) => value = reader.ReadInt32() == 1 ? true : null;

        public override void Move(ref sbyte value) => reader.Read(ref value);
        public override void Move(ref sbyte? value) => value = reader.ReadSByte();

        public override void Move(ref byte value) => reader.Read(ref value);
        public override void Move(ref byte? value) => value = reader.ReadByte();

        public override void Move(ref short value) => reader.Read(ref value);
        public override void Move(ref short? value) => value = reader.ReadInt16();

        public override void Move(ref ushort value) => reader.Read(ref value);
        public override void Move(ref ushort? value) => value = reader.ReadUInt16();

        public override void Move(ref int value) => reader.Read(ref value);
        public override void Move(ref int? value) => value = reader.ReadInt32();

        public override void Move(ref uint value) => reader.Read(ref value);
        public override void Move(ref uint? value) { value = reader.ReadUInt32(); if (value == 0) value = null; }

        public override void Move(ref long value) => reader.Read(ref value);
        public override void Move(ref long? value) => value = reader.ReadInt64();

        public override void Move(ref ulong value) => reader.Read(ref value);
        public override void Move(ref ulong? value) => value = reader.ReadUInt64();

        public override void Move(ref float value) => reader.Read(ref value);
        public override void Move(ref float? value) => value = reader.ReadSingle();

        public override void Move(ref double value) => reader.Read(ref value);
        public override void Move(ref double? value) => value = reader.ReadDouble();

        public override void MoveSingleOrDouble(ref double value) => value = Supports.LARGE_WORLD_COORDINATES ? reader.ReadDouble() : reader.ReadSingle();
        public override void MoveSingleOrDouble(ref double? value) => value = Supports.LARGE_WORLD_COORDINATES ? reader.ReadDouble() : reader.ReadSingle();
        #endregion

        #region Sized Arrays
        public override void Move(ref float[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new float[count]).AsSpan()));
        }
        public override void Move(ref double[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new double[count]).AsSpan()));
        }
        public override void Move(ref byte[] value, int count)
        {
            reader.Read(value = new byte[count]);
        }
        public override void Move(ref Int16[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new Int16[count]).AsSpan()));
        }
        public override void Move(ref UInt16[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new UInt16[count]).AsSpan()));
        }
        public override void Move(ref UInt32[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new UInt32[count]).AsSpan()));
        }
        public override void Move(ref bool[] value, int count)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new bool[count]).AsSpan()));
        }
        #endregion

        #region Array
        public override void Move(ref byte[] value)
        {
            reader.Read(value = new byte[reader.ReadInt32()]);
        }
        public override void Move(ref UInt16[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new UInt16[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref Int32[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new Int32[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref UInt32[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new UInt32[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref Int64[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new Int64[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref UInt64[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new UInt64[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref float[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new float[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref double[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new double[reader.ReadInt32()]).AsSpan()));
        }
        public override void Move(ref bool[] value)
        {
            reader.Read(MemoryMarshal.AsBytes((value = new bool[reader.ReadInt32()]).AsSpan()));
        }
        #endregion

        public override void Move<T>(ref T value, Action<T> action)
        {
            value ??= new T();
            action(value);
        }

        #region ITransferableRaw
        public override void MoveRaw<T>(ref T value)
        {
            value ??= new();
            value.MoveRaw(this);
        }
        public override void MoveRaw<T>(ref T[] value)
        {
            int count = reader.ReadInt32();
            value ??= new T[count];
            for (int i = 0; i < count; i++)
            {
                value[i] ??= new();
                value[i].MoveRaw(this);
            }
        }
        #endregion

        #region ITransferable
        public override void Move<T>(ref T value)
        {
            value ??= new();
            value.Move(this);
        }
        public override void Move<T, T1>(ref T value, T1 arg1)
        {
            value ??= new();
            value.Move(this, arg1);
        }
        public override void Move<T, T1, T2>(ref T value, T1 arg1, T2 arg2)
        {
            value ??= new();
            value.Move(this, arg1, arg2);
        }
        public override void Move<T, T1, T2, T3>(ref T value, T1 arg1, T2 arg2, T3 arg3)
        {
            value ??= new();
            value.Move(this, arg1, arg2, arg3);
        }
        public override void Move<T>(ref List<T> value)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T item = (T)new T().Move(this);
                value.Add(item);
            }
        }
        public override void Move<T, T1, T2>(ref List<T> value, T1 a, T2 b)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T item = (T)new T().Move(this, a, b);
                value.Add(item);
            }
        }
        public override void Move<T>(ref List<List<T>> value)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                List<T> value2 = new();
                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; j++)
                {
                    T item = (T)new T().Move(this);
                    value2.Add(item);
                }
                value.Add(value2);
            }
        }
        public override void Move<T>(ref List<List<T>> value, int count)
        {
            value ??= new();
            for (int i = 0; i < count; i++)
            {
                List<T> value2 = new();
                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; j++)
                {
                    T item = (T)new T().Move(this);
                    value2.Add(item);
                }
                value.Add(value2);
            }
        }
        public override void Move<T>(ref List<T> value, int count)
        {
            value ??= new();
            for (int i = 0; i < count; i++)
            {
                T item = (T)new T().Move(this);
                value.Add(item);
            }
        }
        public override void Move<T>(ref T[] value)
        {
            int size = reader.ReadInt32();
            value = new T[size];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = (T)value[i].Move(this);
            }
        }
        public override void Move<T>(ref T[] value, int count)
        {
            value ??= new T[count];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] ??= new();
                value[i] = (T)value[i].Move(this);
            }
        }

        public override void Move<T1, T2>(ref Dictionary<T1, T2> value)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T1 key = (T1)new T1().Move(this);
                T2 val = (T2)new T2().Move(this);
                value.Add(key, val);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, int count)
        {
            value ??= new();
            for (int i = 0; i < count; i++)
            {
                T1 key = (T1)new T1().Move(this);
                T2 val = (T2)new T2().Move(this);
                value.Add(key, val);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, List<T2>> value)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T1 key = (T1)new T1().Move(this);
                List<T2> val = new List<T2>();
                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; j++)
                {
                    val.Add((T2)new T2().Move(this));
                }
                value.Add(key, val);
            }
        }
        public override void Move<T1, T2, T3>(ref Dictionary<T1, Dictionary<T2, T3>> value)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T1 key = (T1)(new T1()).Move(this);
                Dictionary<T2, T3> val = new();
                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; j++)
                {
                    T2 key2 = (T2)(new T2()).Move(this);
                    T3 val2 = (T3)(new T3()).Move(this);
                    val.Add(key2, val2);
                }
                value.Add(key, val);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T2> valueAction)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T1 key = (T1)new T1().Move(this);
                T2 val = new T2();
                valueAction(val);
                value.Add(key, val);
            }
        }
        #endregion

        #region List
        public override void Move<T>(ref List<T> value, Action<T> action)
        {
            value ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                T item = new();
                action(item);
                value.Add(item);
            }
        }
        public override void Move<T>(ref List<T> value, int count, Action<T> action)
        {
            value ??= new();
            for (int i = 0; i < count; i++)
            {
                T item = new();
                action(item);
                value.Add(item);
            }
        }
        public override void MoveWhile<T>(ref List<T> value, Func<bool> condition, Action<T> action)
        {
            value ??= new();
            while (condition())
            {
                T item = new T();
                action(item);
                value.Add(item);
            }
        }
        #endregion

        #region
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            value.Value = new FGuid(bytes).Value;
            return value;
        }
        public override void Move(ref FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            value = Array.Exists(bytes, x => x != 0) ? new FGuid(bytes) : default;
        }
        public override void Move(ref FGuid? value)
        {
            byte[] bytes = reader.ReadBytes(16);
            value = Array.Exists(bytes, x => x != 0) ? new FGuid(bytes) : null;
        }
        public override FName Move(FName value)
        {
            value ??= new();

            value.ComparisonIndex.Move(this);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex.Value}");

            reader.Read(ref value.Number);

            value.Value = GlobalNames.Get(value.ComparisonIndex);

            if (value.Number > 0)
                GlobalNames.NameToIndexMap[value.DisplayValue] = (value.ComparisonIndex.Value, value.Number);

            return value;
        }
        public override void Move(ref FName value)
        {
            value ??= new();

            value.ComparisonIndex.Move(this);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex.Value}");

            reader.Read(ref value.Number);

            value.Value = GlobalNames.Get(value.ComparisonIndex);

            if (value.Number > 0)
                GlobalNames.NameToIndexMap[value.DisplayValue] = (value.ComparisonIndex.Value, value.Number);
        }
        public override FString Move(FString value)
        {
            Move(ref value);
            return value;
        }
        public override void Move(ref FString value)
        {
            int size = reader.ReadInt32();
            if (size > AppConfig.MaxStringSize)
                throw new InvalidOperationException("FString to big");
            ///if (IsReading && size > (int)Length)
            ///    throw new InvalidOperationException("FString to big");

            bool bLoadUnicodeChar = size < 0;
            if (bLoadUnicodeChar)
                size = -2 * size;
            if (size > 0)
            {
                value ??= new();
                if (bLoadUnicodeChar)
                {
                    value.IsUnicode = true;
                    byte[] bytes = new byte[size];
                    reader.Read(bytes, 0, size);
                    string text = Encoding.Unicode.GetString(bytes);
                    value.Value = text;
                    if (AppConfig.DebugUnicodeStrings)
                    {
                        GlobalObjects.UnicodeStrings.Add(text);
                    }
                }
                else
                {
                    byte[] bytes = size == 1 ? [0] : new byte[size];
                    reader.Read(bytes, 0, size);
                    if (size == 1)
                    {
                        value.Value = "\0";
                    }
                    else if (bytes[^1] == 0)
                    {
                        value.Value = Encoding.ASCII.GetString(bytes, 0, bytes.Length - 1);
                    }
                    else
                    {
                        value.Value = Encoding.ASCII.GetString([.. bytes, Consts.CHAR_TERMINATOR], 0, bytes.Length + 1);
                    }
                }
            }
        }
        public override FText Move(FText value)
        {
            value ??= new();
            value.Move(this);
            return value;
        }
        public override void Move(ref FText value)
        {
            value ??= new();
            value.Move(this);
        }
        public override void Move(ref FTextKey value)
        {
            int size = reader.ReadInt32();
            if (size > 1024)
            {
                throw new InvalidOperationException("FTextKey to big");
            }
            if (size > 0)
            {
                value ??= new();
                byte[] bytes = new byte[size - 1];

                reader.Read(bytes, 0, size - 1);
                _ = reader.ReadByte();

                value.Value = Encoding.ASCII.GetString(bytes);
            }
        }
        #endregion

        public override void Resize<T>(ref List<T> value, bool withNull = false)
        {
            value ??= new();
            int count = reader.ReadInt32();
            if (count == 0)
                return;
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            for (int i = 0; i < count; i++)
            {
                value.Add(withNull ? default : new());
            }
        }

        public override void Resize<T>(ref List<T> value, int count, bool withNull = false)
        {
            value ??= new();
            if (count == 0)
                return;
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            for (int i = 0; i < count; i++)
            {
                value.Add(withNull ? default : new());
            }
        }

        public override void Resize<T>(ref T[] value, int count, bool withNull = false)
        {
            value ??= [];
            if (count == 0)
                return;
            if (count > AppConfig.MaxArraySize)
                throw new InvalidOperationException($"Array MaxSize Exceeded: {count}");
            value = new T[count];
            for (int i = 0; i < count; i++)
            {
                value[i] = withNull ? default : new T();
            }
        }
    }
}
