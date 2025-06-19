namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGBuilderSettings")]
    public class UAssetDefinition_PCGBuilderSettings : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}