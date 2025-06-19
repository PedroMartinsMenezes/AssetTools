namespace AssetTool
{
    [JsonAsset("AssetDefinition")]
    public class UAssetDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}