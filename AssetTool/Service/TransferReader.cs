using System.Text;

namespace AssetTool
{
    public class TransferReader : Transfer
    {
        public TransferReader(BinaryReader reader)
        {
            this.reader = reader;
        }

        public override bool IsReading => true;
        public override bool IsWriting => false;
        public override long Position { get { return reader.BaseStream.Position; } set { reader.BaseStream.Position = value; } }

        #region
        public override void MoveFloat(ref double value) => value = reader.ReadSingle();
        public override void Move(ref sbyte value) => reader.Read(ref value);
        public override void Move(ref byte value) => reader.Read(ref value);
        public override void Move(ref short value) => reader.Read(ref value);
        public override void Move(ref ushort value) => reader.Read(ref value);
        public override void Move(ref int value) => reader.Read(ref value);
        public override void Move(ref uint value) => reader.Read(ref value);
        public override void Move(ref long value) => reader.Read(ref value);
        public override void Move(ref ulong value) => reader.Read(ref value);
        public override void Move(ref float value) => reader.Read(ref value);
        public override void Move(ref double value) => reader.Read(ref value);
        #endregion

        #region
        public override sbyte Move(sbyte value) => reader.Read(ref value);
        public override byte Move(byte value) => reader.Read(ref value);
        public override short Move(short value) => reader.Read(ref value);
        public override ushort Move(ushort value) => reader.Read(ref value);
        public override int Move(int value) => reader.Read(ref value);
        public override uint Move(uint value) => reader.Read(ref value);
        public override long Move(long value) => reader.Read(ref value);
        public override ulong Move(ulong value) => reader.Read(ref value);
        public override float Move(float value) => reader.Read(ref value);
        public override double Move(double value) => reader.Read(ref value);

        public override float[] Move(ref float[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadSingle()).ToArray();
        public override byte[] Move(ref byte[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadByte()).ToArray();
        public override byte[] Move(ref byte[] value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadByte()).ToArray();
        public override List<UInt32> Move(ref List<UInt32> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadUInt32()).ToList();
        #endregion

        #region
        public override FBool Move(FBool value)
        {
            value ??= new();
            value.Value = reader.ReadInt32() == 1;
            return value;
        }
        public override FBool Move(ref FBool value)
        {
            return value = new FBool(reader.ReadInt32());
        }
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            return Array.Exists(bytes, x => x > 0) ? new FGuid(bytes) : null;
        }
        public override FGuid Move(ref FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            return value = Array.Exists(bytes, x => x > 0) ? new FGuid(bytes) : null;
        }
        public override FName Move(FName value)
        {
            var transfer = GlobalObjects.Transfer;
            value ??= new();

            value.ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex}");

            reader.Read(ref value.Number);
            return value;
        }
        public override FName Move(ref FName value)
        {
            var transfer = GlobalObjects.Transfer;
            value ??= new();

            value.ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex}");

            reader.Read(ref value.Number);
            return value;
        }
        public override FString Move(FString value)
        {
            return Move(ref value);
        }
        public override FString Move(ref FString value)
        {
            int size = reader.ReadInt32();
            if (size > 1024 * 1024) throw new InvalidOperationException("FString to big");
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
                }
                else
                {
                    byte[] bytes = new byte[size - 1];
                    reader.Read(bytes, 0, size - 1);
                    string text = Encoding.ASCII.GetString(bytes);
                    _ = reader.ReadByte();
                    value.Value = text;
                    if (text.IndexOf('\0') != -1) throw new InvalidOperationException("Invalid FString");
                }
            }
            return value;
        }
        public override FText Move(FText value)
        {
            value ??= new();
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
            return value;
        }
        #endregion
    }
}
