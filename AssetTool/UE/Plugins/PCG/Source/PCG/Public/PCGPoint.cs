namespace AssetTool
{
    [TransferableStruct("PCGPoint")]
    public class PCGPoint : ITransferable
    {
        public EPCGPointSerializeFields SerializeMask;
        public FTransform Transform;
        public float Density;
        public FVector BoundsMin;
        public FVector BoundsMax;
        public FVector4 Color;
        public float Steepness;
        public int32 Seed;
        public int64 MetadataEntry;

        [Location("bool FPCGPoint::Serialize(FStructuredArchive::FSlot Slot)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.PCGPointStructuredSerializer)
                return null;

            transfer.MoveEnum(ref SerializeMask);
            transfer.Move(ref Transform);

            if (SerializeMask.HasFlag(EPCGPointSerializeFields.Density))
                transfer.Move(ref Density);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.BoundsMin))
                transfer.Move(ref BoundsMin);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.BoundsMax))
                transfer.Move(ref BoundsMax);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.Color))
                transfer.Move(ref Color);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.Steepness))
                transfer.Move(ref Steepness);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.Seed))
                transfer.Move(ref Seed);
            if (SerializeMask.HasFlag(EPCGPointSerializeFields.MetadataEntry))
                transfer.Move(ref MetadataEntry);

            return this;
        }
    }

    [Flags]
    public enum EPCGPointSerializeFields : uint8
    {
        None = 0,
        Density = 1 << 0,
        BoundsMin = 1 << 1,
        BoundsMax = 1 << 2,
        Color = 1 << 3,
        Steepness = 1 << 4,
        Seed = 1 << 5,
        MetadataEntry = 1 << 6
    }
}
