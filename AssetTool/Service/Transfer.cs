namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader;
        public BinaryWriter writer;

        public abstract bool IsReading { get; }
        public abstract bool IsWriting { get; }
        public abstract long Position { get; set; }

        public abstract void MoveFloat(ref double value);
        public abstract void Move(ref sbyte value);
        public abstract void Move(ref byte value);
        public abstract void Move(ref short value);
        public abstract void Move(ref ushort value);
        public abstract void Move(ref int value);
        public abstract void Move(ref uint value);
        public abstract void Move(ref long value);
        public abstract void Move(ref ulong value);
        public abstract void Move(ref float value);
        public abstract void Move(ref double value);

        public abstract sbyte Move(sbyte value);
        public abstract byte Move(byte value);
        public abstract short Move(short value);
        public abstract ushort Move(ushort value);
        public abstract int Move(int value);
        public abstract uint Move(uint value);
        public abstract long Move(long value);
        public abstract ulong Move(ulong value);
        public abstract float Move(float value);
        public abstract double Move(double value);

        public abstract float[] Move(ref float[] value, int size);
        public abstract byte[] Move(ref byte[] value, int size);
        public abstract byte[] Move(ref byte[] value);
        public abstract List<UInt32> Move(ref List<UInt32> value);

        public abstract FBool Move(FBool value);
        public abstract FBool Move(ref FBool value);
        public abstract FGuid Move(FGuid value);
        public abstract FGuid Move(ref FGuid value);
        public abstract FName Move(FName value);
        public abstract FName Move(ref FName value);
        public abstract FString Move(FString value);
        public abstract FString Move(ref FString value);
        public abstract FText Move(FText value);
        public abstract FText Move(ref FText value);
        public abstract FTextKey Move(ref FTextKey value);
    }
}
