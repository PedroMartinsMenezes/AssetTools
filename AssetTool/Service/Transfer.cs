namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader;
        public BinaryWriter writer;

        public abstract void Move(ref sbyte value);
        public abstract void Move(ref byte value);
        public abstract void Move(ref short value);
        public abstract void Move(ref ushort value);
        public abstract void Move(ref int value);
        public abstract void Move(ref uint value);
        public abstract void Move(ref long value);
        public abstract void Move(ref ulong value);

        public abstract sbyte Move(sbyte value);
        public abstract byte Move(byte value);
        public abstract short Move(short value);
        public abstract ushort Move(ushort value);
        public abstract int Move(int value);
        public abstract uint Move(uint value);
        public abstract long Move(long value);
        public abstract ulong Move(ulong value);

        public abstract FBool Move(FBool value);
        public abstract FGuid Move(FGuid value);
    }
}
