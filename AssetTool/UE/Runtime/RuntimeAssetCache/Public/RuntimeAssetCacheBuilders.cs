namespace AssetTool
{
    [JsonAsset("RuntimeAssetCacheBuilder_ObjectBase")]
    public class URuntimeAssetCacheBuilder_ObjectBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExampleTextureCacheBuilder")]
    public class UExampleTextureCacheBuilder : URuntimeAssetCacheBuilder_ObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}