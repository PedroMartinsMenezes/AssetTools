namespace AssetTool
{
    public class FObjectDataResource : ITransferable<uint32>
    {
        public EObjectDataResourceFlags Flags = EObjectDataResourceFlags.None;
        public FBulkDataCookedIndex CookedIndex;
        public int64 SerialOffset;
        public int64 DuplicateSerialOffset;
        public int64 SerialSize;
        public int64 RawSize;
        public FPackageIndex OuterIndex;
        public uint32 LegacyBulkDataFlags;

        [Location("void FObjectDataResource::Serialize(FStructuredArchive::FSlot Slot, TArray<FObjectDataResource>& DataResources)")]
        public ITransferable Move(Transfer transfer, uint32 Version)
        {
            transfer.MoveEnum(ref Flags);
            if (Version >= (uint32)EVersion.AddedCookedIndex)
            {
                transfer.Move(ref CookedIndex);
            }
            transfer.Move(ref SerialOffset);
            transfer.Move(ref DuplicateSerialOffset);
            transfer.Move(ref SerialSize);
            transfer.Move(ref RawSize);
            transfer.Move(ref OuterIndex);
            transfer.Move(ref LegacyBulkDataFlags);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public enum EVersion : uint32
        {
            Invalid,
            Initial,
            AddedCookedIndex,
            LatestPlusOne,
            Latest = LatestPlusOne - 1
        };
    }

    public enum EObjectDataResourceFlags : uint32
    {
        None = 0,
        Inline = (1 << 0),
        Streaming = (1 << 1),
        Optional = (1 << 2),
        Duplicate = (1 << 3),
        MemoryMapped = (1 << 4),
        DerivedDataReference = (1 << 5),
    };


}
