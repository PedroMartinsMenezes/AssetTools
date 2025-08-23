using System.Runtime.InteropServices;

namespace AssetTool
{
    public class TransferWriter : Transfer, IDisposable
    {
        public TransferWriter(BinaryWriter writer, Transfer other = default, bool fromJson = false)
        {
            this.writer = writer;
            Initialize(other);
            FromJson = fromJson;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                this.writer.Dispose();
                _disposed = true;
            }
        }

        public override bool IsReading => false;
        public override bool IsWriting => true;
        public override bool FromJson { get; init; }
        public override long Position { get { return writer.BaseStream.Position; } set { writer.BaseStream.Position = value; } }
        public override long Length => writer.BaseStream.Length;
        public override long Counter { get; set; }
        public override long BaseOffset { get; set; }
        public override Stream Stream => writer.BaseStream;
        private bool _disposed;

        public override void MoveConst(Int32 value)
        {
            writer.Write(value);
        }

        public override void MoveAsUInt16(ref Int32 value) => writer.Write((ushort)value);
        public override void MoveAsUInt16(ref Int32? value) => writer.Write((ushort)value.Value);

        public override void MoveAsByte(ref UInt16 value) => writer.Write((byte)value);
        public override void MoveAsByte(ref UInt16? value) => writer.Write((byte)value.Value);

        public override void MoveAsInt(ref Int64 value) => writer.Write((int)value);
        public override void MoveAsInt(ref Int64? value) => writer.Write((int)value.Value);

        public override void MoveEnum<T>(ref T value)
        {
            writer.Write(MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan<T>(ref value, 1)));
        }

        public override void MoveEnum<T>(ref T? value)
        {
            T temp = value.HasValue ? value.Value : default;
            writer.Write(MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan<T>(ref temp, 1)));
        }

        public override void MoveEnum<T>(ref T[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }

        public override void MoveEnum<T>(ref T[] value, int index)
        {
            T item = value[index];
            MoveEnum(ref item);
        }

        #region
        public override void MoveFloat(ref double value) => writer.Write((float)value);
        public override void MoveFloat(ref double? value) => writer.Write((float)value);

        public override void Move(ref bool value) => writer.Write(value ? 1 : 0);
        public override void Move(ref bool? value) => writer.Write(value.Value ? 1 : 0);

        public override void Move(ref sbyte value) => writer.Write(value);
        public override void Move(ref sbyte? value) => writer.Write(value.Value);

        public override void Move(ref byte value) => writer.Write(value);
        public override void Move(ref byte? value) => writer.Write(value.Value);

        public override void Move(ref short value) => writer.Write(value);
        public override void Move(ref short? value) => writer.Write(value.Value);

        public override void Move(ref ushort value) => writer.Write(value);
        public override void Move(ref ushort? value) => writer.Write(value.Value);

        public override void Move(ref int value) => writer.Write(value);
        public override void Move(ref int? value) => writer.Write(value.Value);

        public override void Move(ref uint value) => writer.Write(value);
        public override void Move(ref uint? value) => writer.Write(value.Value);

        public override void Move(ref long value) => writer.Write(value);
        public override void Move(ref long? value) => writer.Write(value.Value);

        public override void Move(ref ulong value) => writer.Write(value);
        public override void Move(ref ulong? value) => writer.Write(value.Value);

        public override void Move(ref float value) => writer.Write(value);
        public override void Move(ref float? value) => writer.Write(value.Value);

        public override void Move(ref double value) => writer.Write(value);
        public override void Move(ref double? value) => writer.Write(value.Value);

        public override void MoveSingleOrDouble(ref double value)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
                writer.Write(value);
            else
                writer.Write((float)value);
        }

        public override void MoveSingleOrDouble(ref double? value)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
                writer.Write(value.Value);
            else
                writer.Write((float)value.Value);
        }
        #endregion

        #region Sized Arrays
        public override void Move(ref float[] value, int count)
        {
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref byte[] value, int count)
        {
            writer.Write(value);
        }
        public override void Move(ref Int16[] value, int count)
        {
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref UInt16[] value, int count)
        {
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref UInt32[] value, int count)
        {
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        #endregion

        #region Arrays
        public override void Move(ref byte[] value)
        {
            writer.Write(value.Length);
            writer.Write(value);
        }
        public override void Move(ref UInt16[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref Int32[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref UInt32[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref Int64[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref UInt64[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref float[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        public override void Move(ref double[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        #endregion

        public override void Move<T>(ref T value, Action<T> action)
        {
            action(value);
        }

        #region ITransferibleRaw
        public override void MoveRaw<T>(ref T value)
        {
            writer.Write(MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan<T>(ref value, 1)));
        }
        public override void MoveRaw<T>(ref T[] value)
        {
            writer.Write(value.Length);
            writer.Write(MemoryMarshal.AsBytes(value.AsSpan()));
        }
        #endregion

        #region ITransferible
        public override void Move<T>(ref T value)
        {
            value.Move(this);
        }
        public override void Move<T, T1>(ref T value, T1 arg1)
        {
            value.Move(this, arg1);
        }
        public override void Move<T, T1, T2>(ref T value, T1 arg1, T2 arg2)
        {
            value.Move(this, arg1, arg2);
        }
        public override void Move<T, T1, T2, T3>(ref T value, T1 arg1, T2 arg2, T3 arg3)
        {
            value.Move(this, arg1, arg2, arg3);
        }
        public override void Move<T>(ref List<T> value)
        {
            writer.Write(value.Count);
            value.ForEach(item => item.Move(this));
        }
        public override void Move<T, T1, T2>(ref List<T> value, T1 a, T2 b)
        {
            writer.Write(value.Count);
            value.ForEach(item => item.Move(this, a, b));
        }
        public override void Move<T>(ref List<List<T>> value)
        {
            writer.Write(value.Count);
            value.ForEach(item => this.Move(ref item));
        }
        public override void Move<T>(ref List<List<T>> value, int count)
        {
            value.ForEach(item => this.Move(ref item));
        }
        public override void Move<T>(ref List<T> value, int count)
        {
            value.ForEach(item => item.Move(this));
        }
        public override void Move<T>(ref T[] value)
        {
            writer.Write(value.Length);
            for (int i = 0; i < value.Length; i++)
            {
                value[i].Move(this);
            }
        }
        public override void Move<T>(ref T[] value, int count)
        {
            for (int i = 0; i < value.Length; i++)
            {
                value[i].Move(this);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value)
        {
            writer.Write(value.Count);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                pair.Value.Move(this);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, int count)
        {
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                pair.Value.Move(this);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, List<T2>> value)
        {
            writer.Write(value.Count);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                writer.Write(pair.Value.Count);
                pair.Value.ForEach(item => item.Move(this));
            }
        }
        public override void Move<T1, T2, T3>(ref Dictionary<T1, Dictionary<T2, T3>> value)
        {
            writer.Write(value.Count);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                writer.Write(pair.Value.Count);
                foreach (var pair2 in pair.Value)
                {
                    pair2.Key.Move(this);
                    pair2.Value.Move(this);
                }
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T2> valueAction)
        {
            writer.Write(value.Count);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                valueAction(pair.Value);
            }
        }
        #endregion

        #region List
        public override void Move<T>(ref List<T> value, Action<T> action)
        {
            writer.Write(value.Count);
            value.ForEach(item => action(item));
        }
        public override void Move<T>(ref List<T> value, int count, Action<T> action)
        {
            value.ForEach(item => action(item));
        }
        public override void MoveWhile<T>(ref List<T> value, Func<bool> condition, Action<T> action)
        {
            value.ForEach(item => action(item));
        }
        #endregion

        #region
        public override void Move(ref FBool value)
        {
            writer.Write(value ? 1 : 0);
        }
        public override void Move(ref FBool? value)
        {
            writer.Write(value.HasValue && value.Value.Value ? 1 : 0);
        }
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = value.ToByteArray() ?? new byte[16];
            writer.Write(bytes);
            return value;
        }
        public override void Move(ref FGuid value)
        {
            byte[] bytes = value.ToByteArray() ?? new byte[16];
            writer.Write(bytes);
        }
        public override void Move(ref FGuid? value)
        {
            byte[] bytes = value.HasValue ? value.Value.ToByteArray() : new byte[16];
            writer.Write(bytes);
        }
        public override FName Move(FName value)
        {
            if (value.IncompleteDeserialization)
            {
                value.IncompleteDeserialization = false;
                (value.ComparisonIndex.Value, value.Number) = FName.GetIndexAndNumber(value.Value, this);
            }
            writer.Write(value.ComparisonIndex.Value);
            writer.Write(value.Number);
            return value;
        }
        public override void Move(ref FName value)
        {
            if (value.IncompleteDeserialization)
            {
                value.IncompleteDeserialization = false;
                (value.ComparisonIndex.Value, value.Number) = FName.GetIndexAndNumber(value.Value, this);
            }
            writer.Write(value.ComparisonIndex.Value);
            writer.Write(value.Number);
        }
        public override FString Move(FString value)
        {
            Move(ref value);
            return value;
        }
        public override void Move(ref FString value)
        {
            int length = value?.Length ?? 0;
            if (length > 0)
            {
                if (AppConfig.DebugUnicodeStrings)
                {
                    if (!value.IsUnicode && GlobalObjects.UnicodeStrings.Contains(value.Value))
                    {
                        throw new InvalidOperationException();
                    }
                }
                if (value.IsUnicode)
                {
                    length = -1 * length / 2;
                    writer.Write(length);
                    byte[] bytes = value.ToByteArray();
                    writer.Write(bytes);
                }
                else
                {
                    length = value.Value[0] == '\0' ? 1 : (value.Value[^1] == Consts.CHAR_TERMINATOR ? length - 2 : length);
                    writer.Write(length);
                    writer.Write(value.ToByteArray().Take(length).ToArray());
                    if (value.Value[0] != '\0' && value.Value[^1] != Consts.CHAR_TERMINATOR)
                        writer.Write((byte)0);
                }
            }
            else
            {
                writer.Write(0);
            }
        }
        public override FText Move(FText value)
        {
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
            if (value is { })
            {
                writer.Write(value.Length);
                writer.Write(value.ToByteArray());
                writer.Write((byte)0);
            }
            else
            {
                writer.Write(0);
            }
        }
        #endregion

        public override void Resize<T>(ref List<T> value, bool withNull = false)
        {
            writer.Write(value.Count);
        }

        public override void Resize<T>(ref List<T> value, int count, bool withNull = false)
        {
        }

        public override void Resize<T>(ref T[] value, int count, bool withNull = false)
        {
        }
    }
}
