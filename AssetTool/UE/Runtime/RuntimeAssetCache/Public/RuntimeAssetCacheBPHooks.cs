namespace AssetTool
{
    [JsonAsset("RuntimeAssetCacheBPHooks")]
    public class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}