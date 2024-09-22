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
        public override List<UInt32> Move(ref List<UInt32> value)
        {
            writer.Write(value.Count);
            value.ToList().ForEach(writer.Write);
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
