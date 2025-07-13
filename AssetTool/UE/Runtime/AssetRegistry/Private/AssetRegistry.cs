namespace AssetTool
{
    [JsonAsset("AssetRegistryImpl")]
    public class UAssetRegistryImpl : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}