namespace AssetTool
{
    [JsonAsset("AssetDefinitionDefault")]
    public class UAssetDefinitionDefault : UAssetDefinition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}