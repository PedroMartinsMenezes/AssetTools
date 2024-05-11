namespace AssetTool
{
    public class TransferReader : Transfer
    {
        public TransferReader(BinaryReader reader)
        {
            this.reader = reader;
        }

        #region
        public override void Move(ref sbyte value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref byte value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref short value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref ushort value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref int value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref uint value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref long value)
        {
            reader.Read(ref value);
        }

        public override void Move(ref ulong value)
        {
            reader.Read(ref value);
        }
        #endregion

        #region
        public override sbyte Move(sbyte value)
        {
            return reader.Read(ref value);
        }

        public override byte Move(byte value)
        {
            return reader.Read(ref value);
        }

        public override short Move(short value)
        {
            return reader.Read(ref value);
        }

        public override ushort Move(ushort value)
        {
            return reader.Read(ref value);
        }

        public override int Move(int value)
        {
            return reader.Read(ref value);
        }

        public override uint Move(uint value)
        {
            return reader.Read(ref value);
        }

        public override long Move(long value)
        {
            return reader.Read(ref value);
        }

        public override ulong Move(ulong value)
        {
            return reader.Read(ref value);
        }
        #endregion

        #region
        public override FBool Move(FBool value)
        {
            value ??= new();
            value.Value = reader.ReadInt32() == 1;
            return value;
        }
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            return Array.Exists(bytes, x => x > 0) ? new FGuid(bytes) : null;
        }
        #endregion
    }
}
