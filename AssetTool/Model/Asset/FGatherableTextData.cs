namespace AssetTool
{
    public class FGatherableTextData
    {
        public FString NamespaceName;
        public FTextSourceData SourceData;
        public List<FTextSourceSiteContext> SourceSiteContexts;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FGatherableTextData& This)")]
        public FGatherableTextData Move(Transfer transfer)
        {
            transfer.Move(ref NamespaceName);
            transfer.Move(ref SourceData);
            transfer.Move(ref SourceSiteContexts);
            return this;
        }
    }
}
