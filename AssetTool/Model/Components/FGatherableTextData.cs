namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FGatherableTextData& This)")]
    public class FGatherableTextData
    {
        public FString NamespaceName;
        public FTextSourceData SourceData = new();
        public List<FTextSourceSiteContext> SourceSiteContexts = [];

        public FGatherableTextData Move(Transfer transfer)
        {
            transfer.Move(ref NamespaceName);
            transfer.Move(ref SourceData.SourceString);
            transfer.Move(ref SourceData.SourceStringMetaData);
            SourceSiteContexts.Resize(transfer);
            foreach (var context in SourceSiteContexts)
            {
                transfer.Move(ref context.KeyName);
                transfer.Move(ref context.SiteDescription);
                transfer.Move(ref context.IsEditorOnly);
                transfer.Move(ref context.IsOptional);

                context.InfoMetaData.MapKeys.Resize(GlobalObjects.Transfer);
                for (int i = 0; i < context.InfoMetaData.MapKeys.Count; i++)
                {
                    transfer.Move(context.InfoMetaData.MapKeys[i]);
                }

                context.KeyMetaData.MapKeys.Resize(GlobalObjects.Transfer);
                for (int i = 0; i < context.KeyMetaData.MapKeys.Count; i++)
                {
                    transfer.Move(context.KeyMetaData.MapKeys[i]);
                }
            }
            return this;
        }
    }
}
