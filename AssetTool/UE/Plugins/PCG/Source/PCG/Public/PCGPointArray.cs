namespace AssetTool
{
    [TransferibleStruct("PCGPointArray")]
    public class FPCGPointArray : ITransferible
    {
        public int32 NumPoints;
        public FPCGPointArrayProperty<FTransform> Transform;
        public FPCGPointArrayProperty<TFloat> Density;
        public FPCGPointArrayProperty<FVector> BoundsMin;
        public FPCGPointArrayProperty<FVector> BoundsMax;
        public FPCGPointArrayProperty<FVector4> Color;
        public FPCGPointArrayProperty<TFloat> Steepness;
        public FPCGPointArrayProperty<TInt32> Seed;
        public FPCGPointArrayProperty<TInt64> MetadataEntry;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumPoints);
            transfer.Move(ref Transform);
            transfer.Move(ref Density);
            transfer.Move(ref BoundsMin);
            transfer.Move(ref BoundsMax);
            transfer.Move(ref Color);
            transfer.Move(ref Steepness);
            transfer.Move(ref Seed);
            transfer.Move(ref MetadataEntry);
            return this;
        }
    }

    public class FPCGPointArrayProperty<T> : ITransferible where T : ITransferible, new()
    {
        public int32 NumValues;
        public T Value;
        public List<T> Values;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumValues);
            transfer.Move(ref Value);
            transfer.Move(ref Values);
            return this;
        }
    }
}
