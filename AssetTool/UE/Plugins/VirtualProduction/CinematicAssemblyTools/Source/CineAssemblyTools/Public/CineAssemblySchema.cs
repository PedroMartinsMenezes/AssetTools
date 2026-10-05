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

            foreach (var pair in Members)
            {
                if (pair.Key.Contains("'AssemblyMetadata'"))
                {
                    if (pair.Value is FPropertyTag tag && tag.Value is List<object> list1)
                    {
                        AssemblyMetadataCount = list1.Count;
                    }
                    else if (pair.Value is List<object> list2)
                    {
                        AssemblyMetadataCount = list2.Count;
                    }
                }
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