namespace AssetTool
{
    [JsonAsset("AssetDefinitionRegistry")]
    public class UAssetDefinitionRegistry : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}