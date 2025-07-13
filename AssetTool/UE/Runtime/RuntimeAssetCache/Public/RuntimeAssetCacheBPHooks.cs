namespace AssetTool
{
    [JsonAsset("RuntimeAssetCacheBPHooks")]
    public class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}