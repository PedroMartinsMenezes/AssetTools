namespace AssetTool
{
    [JsonAsset("AnimAssetFindReplaceContext")]
    public class UAnimAssetFindReplaceContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimAssetFindReplaceProcessor")]
    public class UAnimAssetFindReplaceProcessor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimAssetFindReplaceProcessor_StringBase")]
    public class UAnimAssetFindReplaceProcessor_StringBase : UAnimAssetFindReplaceProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}