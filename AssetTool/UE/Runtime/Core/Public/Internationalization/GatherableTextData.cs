using System.Diagnostics;

namespace AssetTool
{
    public class FTextSourceSiteContext : ITransferable
    {
        public FString KeyName;
        public FString SiteDescription;
        public bool IsEditorOnly;
        public bool IsOptional;
        public FLocMetadataObject InfoMetaData;
        public FLocMetadataObject KeyMetaData;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FTextSourceSiteContext& This)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref KeyName);
            transfer.Move(ref SiteDescription);
            transfer.Move(ref IsEditorOnly);
            transfer.Move(ref IsOptional);
            transfer.Move(ref InfoMetaData);
            transfer.Move(ref KeyMetaData);
            return this;
        }
    }

    [DebuggerDisplay("{SourceString}")]
    public class FTextSourceData : ITransferable
    {
        public FString SourceString;
        public UInt32 SourceStringMetaData;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SourceString);
            transfer.Move(ref SourceStringMetaData);
            return this;
        }
    }

    public class FGatherableTextData : ITransferable
    {
        public FString NamespaceName;
        public FTextSourceData SourceData;
        public List<FTextSourceSiteContext> SourceSiteContexts;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FGatherableTextData& This)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NamespaceName);
            transfer.Move(ref SourceData);
            transfer.Move(ref SourceSiteContexts);
            return this;
        }
    }
}
