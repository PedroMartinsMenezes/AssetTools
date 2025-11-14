namespace AssetTool
{
    [JsonAsset("CineAssemblySchema")]
    public class UCineAssemblySchema : UObject
    {
        public int AssemblyMetadataCount;
        public List<FAssemblyMetadataDesc> AssemblyMetadata;

        [Location("void UCineAssemblySchema::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Members.TryGetValue("AssemblyMetadata", out object value) && value is FPropertyTag tag && tag.Value is List<object> list)
            {
                AssemblyMetadataCount = list.Count;
            }
            transfer.Move(ref AssemblyMetadata, AssemblyMetadataCount);
            return this;
        }
    }

    public class FAssemblyMetadataDesc : ITransferable
    {
        public TVariant<FString, TBool, TInt32, TFloat> DefaultValue;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref DefaultValue);
            return this;
        }
    }
}