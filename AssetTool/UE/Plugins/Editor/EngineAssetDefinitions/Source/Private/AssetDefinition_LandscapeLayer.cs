namespace AssetTool
{
    [JsonAsset("AssetDefinition_LandscapeLayer")]
    public class UAssetDefinition_LandscapeLayer : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}