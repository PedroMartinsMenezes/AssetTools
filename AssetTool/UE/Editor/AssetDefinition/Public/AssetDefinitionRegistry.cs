namespace AssetTool
{
    [JsonAsset("AssetDefinitionRegistry")]
    public class UAssetDefinitionRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}