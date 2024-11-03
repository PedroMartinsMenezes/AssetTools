namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader; //@@@ remove
        public BinaryWriter writer; //@@@ remove

        public abstract bool IsReading { get; }
        public abstract bool IsWriting { get; }
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

        public abstract float[] Move(ref float[] value, int size);
        public abstract byte[] Move(ref byte[] value, int size);
        public abstract Int16[] Move(ref Int16[] value, int size);
        public abstract UInt16[] Move(ref UInt16[] value, int size);
        public abstract UInt32[] Move(ref UInt32[] value, int size);
        public abstract byte[] Move(ref byte[] value);

        public abstract List<sbyte> Move(ref List<sbyte> value);
        public abstract List<byte> Move(ref List<byte> value);
        public abstract List<Int16> Move(ref List<Int16> value);
        public abstract List<UInt16> Move(ref List<UInt16> value);
        public abstract List<Int32> Move(ref List<Int32> value);
        public abstract List<UInt32> Move(ref List<UInt32> value);
        public abstract List<float> Move(ref List<float> value);

        public abstract T MoveObject<T>(ref T value) where T : UObject;

        public abstract T Move<T>(ref T value) where T : ITransferible;
        public abstract T MoveRaw<T>(ref T value) where T : ITransferibleRaw;
        public abstract List<T> Move<T>(ref List<T> value) where T : ITransferible, new();
        public abstract List<T> Move<T>(ref List<T> value, ref int elementSize) where T : ITransferible, new();
        public abstract List<T> Move<T>(ref List<T> value, int count) where T : ITransferible, new();
        public abstract T[] Move<T>(ref T[] value) where T : ITransferible;
        public abstract Dictionary<T1, T2> Move<T1, T2>(ref Dictionary<T1, T2> value) where T1 : ITransferible where T2 : ITransferible;
        public abstract Dictionary<T1, List<T2>> Move<T1, T2>(ref Dictionary<T1, List<T2>> value) where T1 : ITransferible where T2 : ITransferible;
        public abstract Dictionary<T1, Dictionary<T2, T3>> Move<T1, T2, T3>(ref Dictionary<T1, Dictionary<T2, T3>> value) where T1 : ITransferible where T2 : ITransferible where T3 : ITransferible;

        public abstract List<T> Move<T>(ref List<T> value, Action<T> action) where T : new();
        public abstract Dictionary<T1, T2> Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2) where T1 : new() where T2 : new();

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
