namespace AssetTool
{
    [JsonAsset("AnimAssetFindReplaceContext")]
    public class UAnimAssetFindReplaceContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimAssetFindReplaceProcessor")]
    public class UAnimAssetFindReplaceProcessor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimAssetFindReplaceProcessor_StringBase")]
    public class UAnimAssetFindReplaceProcessor_StringBase : UAnimAssetFindReplaceProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}