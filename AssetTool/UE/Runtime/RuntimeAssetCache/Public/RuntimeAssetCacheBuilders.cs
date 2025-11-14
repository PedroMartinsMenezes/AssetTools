namespace AssetTool
{
    [JsonAsset("RuntimeAssetCacheBuilder_ObjectBase")]
    public class URuntimeAssetCacheBuilder_ObjectBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExampleTextureCacheBuilder")]
    public class UExampleTextureCacheBuilder : URuntimeAssetCacheBuilder_ObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}