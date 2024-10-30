namespace AssetTool
{
    [JsonAsset("AssetDefinition")]
    public class UAssetDefinition : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}