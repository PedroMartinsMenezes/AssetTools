using System.Runtime.InteropServices;

namespace AssetTool
{
    public class TransferWriter : Transfer
    {
        public TransferWriter(BinaryWriter writer)
        {
            this.writer = writer;
        }
        public override bool IsReading => false;
        public override bool IsWriting => true;
        public override long Position { get { return writer.BaseStream.Position; } set { writer.BaseStream.Position = value; } }
        public override long Length => writer.BaseStream.Length;
        public override long Counter { get; set; }
        public override Stream Stream => writer.BaseStream;

        #region
        public override void MoveFloat(ref double value) => writer.Write((float)value);
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
        public override float[] Move(ref float[] value, int size)
        {
            value.ToList().ForEach(x => writer.Write(x));
            return value;
        }
        public override byte[] Move(ref byte[] value, int size)
        {
            writer.Write(value);
            return value;
        }
        public override Int16[] Move(ref Int16[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<Int16>(value)));
            return value;
        }
        public override UInt16[] Move(ref UInt16[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<UInt16>(value)));
            return value;
        }
        public override UInt32[] Move(ref UInt32[] value, int size)
        {
            writer.Write(MemoryMarshal.AsBytes(new Span<UInt32>(value)));
            return value;
        }
        public override byte[] Move(ref byte[] value)
        {
            writer.Write(value.Length);
            writer.Write(value);
            return value;
        }
        public override List<sbyte> Move(ref List<sbyte> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<byte> Move(ref List<byte> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<Int16> Move(ref List<Int16> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<UInt16> Move(ref List<UInt16> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<Int32> Move(ref List<Int32> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<UInt32> Move(ref List<UInt32> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        public override List<float> Move(ref List<float> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
            return value;
        }
        #endregion

        public override T MoveObject<T>(ref T value)
        {
            value ??= Activator.CreateInstance<T>();
            value.Move(this);
            return value;
        }

        #region ITransferible
        public override T Move<T>(ref T value)
        {
            value ??= Activator.CreateInstance<T>();
            value.Move(this);
            return value;
        }
        public override List<T> Move<T>(ref List<T> value)
        {
            value ??= new();
            value.Resize(this);
            value.ForEach(item => item.Move(this));
            return value;
        }
        public override T[] Move<T>(ref T[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                value[i].Move(this);
            }
            return value;
        }
        public override Dictionary<T1, T2> Move<T1, T2>(ref Dictionary<T1, T2> value)
        {
            value ??= new();
            value.Resize(this);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                pair.Value.Move(this);
            }
            return value;
        }
        #endregion

        #region List
        public override List<T> Move<T>(ref List<T> value, Action<T> action)
        {
            value ??= new();
            value.Resize(this);
            value.ForEach(item => action(item));
            return value;
        }
        #endregion

        #region Dictionary
        public override Dictionary<T1, T2> Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2)
        {
            value ??= new();
            value.Resize(this);
            foreach (var pair in value)
            {
                act1(pair.Key);
                act2(pair.Value);
            }
            return value;
        }
        #endregion

        #region
        public override FBool Move(FBool value)
        {
            writer.Write(value.Value ? 1 : 0);
            return value;
        }
        public override FBool Move(ref FBool value)
        {
            writer.Write(value?.Value == true ? 1 : 0);
            return value;
        }
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = value?.ToByteArray() ?? new byte[16];
            writer.Write(bytes);
            return value;
        }
        public override FGuid Move(ref FGuid value)
        {
            byte[] bytes = value?.ToByteArray() ?? new byte[16];
            writer.Write(bytes);
            return value;
        }
        public override FName Move(FName value)
        {
            writer.Write(value.ComparisonIndex.Value);
            writer.Write(value.Number);
            return value;
        }
        public override FName Move(ref FName value)
        {
            writer.Write(value.ComparisonIndex.Value);
            writer.Write(value.Number);
            return value;
        }
        public override FString Move(FString value)
        {
            return Move(ref value);
        }
        public override FString Move(ref FString value)
        {
            int length = value?.Length ?? 0;
            if (length > 0)
            {
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
            return value;
        }
        public override FText Move(FText value)
        {
            value.Move(this);
            return value;
        }
        public override FText Move(ref FText value)
        {
            value ??= new();
            value.Move(this);
            return value;
        }
        public override FTextKey Move(ref FTextKey value)
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
            return value;
        }
        #endregion
    }
}
