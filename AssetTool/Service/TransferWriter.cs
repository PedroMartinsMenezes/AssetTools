using System.Runtime.InteropServices;

namespace AssetTool
{
    public class TransferWriter : Transfer
    {
        public TransferWriter(BinaryWriter writer, Transfer other = null, bool fromJson = false)
        {
            this.writer = writer;
            Initialize(other);
            FromJson = fromJson;
        }
        public override bool IsReading => false;
        public override bool IsWriting => true;
        public override bool FromJson { get; init; }
        public override long Position { get { return writer.BaseStream.Position; } set { writer.BaseStream.Position = value; } }
        public override long Length => writer.BaseStream.Length;
        public override long Counter { get; set; }
        public override long BaseOffset { get; set; }
        public override Stream Stream => writer.BaseStream;

        public override void MoveEnum<T>(ref T value)
        {
            Type enumType = typeof(T);
            Type underlyingType = Enum.GetUnderlyingType(enumType);
            if (underlyingType == typeof(byte))
            {
                byte valueUint8 = Convert.ToByte(value);
                writer.Write(valueUint8);
            }
            else if (underlyingType == typeof(uint))
            {
                UInt32 valueUint32 = Convert.ToUInt32(value);
                writer.Write(valueUint32);
            }
            else if (underlyingType == typeof(int))
            {
                Int32 valueInt32 = Convert.ToInt32(value);
                writer.Write(valueInt32);
            }
            else
            {
                throw new InvalidOperationException("Invalid Enum");
            }
        }

        #region
        public override void MoveFloat(ref double value) => writer.Write((float)value);
        public override void Move(ref bool value) => writer.Write(value ? 1 : 0);
        public override void Move(ref sbyte value) => writer.Write(value);
        public override void Move(ref byte value) => writer.Write(value);
        public override void Move(ref short value) => writer.Write(value);
        public override void Move(ref ushort value) => writer.Write(value);
        public override void Move(ref int value) => writer.Write(value);
        public override void Move(ref uint value) => writer.Write(value);
        public override void Move(ref long value) => writer.Write(value);
        public override void Move(ref ulong value) => writer.Write(value);
        public override void Move(ref float value) => writer.Write(value);
        public override void Move(ref double value) => writer.Write(value);
        public override void MoveSingleOrDouble(ref double value)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
                writer.Write(value);
            else
                writer.Write((float)value);
        }
        #endregion

        #region
        public override sbyte Move(sbyte value)
        {
            writer.Write(value);
            return value;
        }
        public override byte Move(byte value)
        {
            writer.Write(value);
            return value;
        }
        public override short Move(short value)
        {
            writer.Write(value);
            return value;
        }
        public override ushort Move(ushort value)
        {
            writer.Write(value);
            return value;
        }
        public override int Move(int value)
        {
            writer.Write(value);
            return value;
        }
        public override uint Move(uint value)
        {
            writer.Write(value);
            return value;
        }
        public override long Move(long value)
        {
            writer.Write(value);
            return value;
        }
        public override ulong Move(ulong value)
        {
            writer.Write(value);
            return value;
        }
        public override float Move(float value)
        {
            writer.Write(value);
            return value;
        }
        public override double Move(double value)
        {
            writer.Write(value);
            return value;
        }
        public override void Move(ref float[] value, int size)
        {
            value.ToList().ForEach(x => writer.Write(x));
        }
        public override void Move(ref byte[] value, int size)
        {
            writer.Write(value);
        }
        public override void Move(ref Int16[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<Int16>(value)));
        }
        public override void Move(ref UInt16[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<UInt16>(value)));
        }
        public override void Move(ref UInt32[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<UInt32>(value)));
        }

        public override void Move(ref byte[] value)
        {
            writer.Write(value.Length);
            writer.Write(value);
        }
        public override void Move(ref UInt16[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref Int32[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref UInt32[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref Int64[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref UInt64[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref float[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref double[] value)
        {
            writer.Write(value.Length);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<sbyte> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<byte> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<Int16> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<UInt16> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<Int32> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<UInt32> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<float> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        public override void Move(ref List<double> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
        }
        #endregion

        public override void MoveObject<T>(ref T value)
        {
            value.Move(this);
        }

        public override void Move<T>(ref T value, Action<T> action)
        {
            action(value);
        }

        #region ITransferibleRaw
        public override void MoveRaw<T>(ref T value)
        {
            value.MoveRaw(this);
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
            for (int i = 0; i < value.Length; i++)
            {
                value[i].Move(this);
            }
        }
        public override void Move<T>(ref T[] value, int size)
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
        public override FName Move(FName value)
        {
            writer.Write(value.ComparisonIndex.Value);
            writer.Write(value.Number);
            return value;
        }
        public override void Move(ref FName value)
        {
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
                    length = value.Value[0] == '\0' ? 1 : length;
                    writer.Write(length);
                    writer.Write(value.ToByteArray());
                    if (value.Value[0] != '\0')
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
    }
}
