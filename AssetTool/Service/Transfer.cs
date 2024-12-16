namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader; //@@@ remove
        public BinaryWriter writer; //@@@ remove

        public abstract bool IsReading { get; }
        public abstract bool IsWriting { get; }
        public abstract bool FromJson { get; init; }
        public abstract long Position { get; set; }
        public abstract long Length { get; }
        public abstract long Counter { get; set; }
        public abstract Stream Stream { get; }

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

        public abstract void Move(ref float[] value, int size);
        public abstract void Move(ref byte[] value, int size);
        public abstract void Move(ref Int16[] value, int size);
        public abstract void Move(ref UInt16[] value, int size);
        public abstract void Move(ref UInt32[] value, int size);
        public abstract void Move(ref byte[] value);

        public abstract void Move(ref List<sbyte> value);
        public abstract void Move(ref List<byte> value);
        public abstract void Move(ref List<Int16> value);
        public abstract void Move(ref List<UInt16> value);
        public abstract void Move(ref List<Int32> value);
        public abstract void Move(ref List<UInt32> value);
        public abstract void Move(ref List<float> value);

        public abstract void MoveObject<T>(ref T value) where T : UObject;

        public abstract void Move<T>(ref T value) where T : ITransferible;
        public abstract void MoveRaw<T>(ref T value) where T : ITransferibleRaw;
        public abstract void Move<T>(ref List<T> value) where T : ITransferible, new();
        public abstract void Move<T>(ref List<T> value, ref int elementSize) where T : ITransferible, new();
        public abstract void Move<T>(ref List<T> value, int count) where T : ITransferible, new();
        public abstract void Move<T>(ref T[] value) where T : ITransferible;
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value) where T1 : ITransferible where T2 : ITransferible;
        public abstract void Move<T1, T2>(ref Dictionary<T1, List<T2>> value) where T1 : ITransferible where T2 : ITransferible;

        public abstract void Move<T>(ref List<T> value, Action<T> action) where T : new();
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2) where T1 : new() where T2 : new();

        public abstract FBool Move(FBool value);
        public abstract void Move(ref FBool value);
        public abstract FGuid Move(FGuid value);
        public abstract void Move(ref FGuid value);
        public abstract FName Move(FName value);
        public abstract void Move(ref FName value);
        public abstract FString Move(FString value);
        public abstract void Move(ref FString value);
        public abstract FText Move(FText value);
        public abstract void Move(ref FText value);
        public abstract void Move(ref FTextKey value);
    }
}
