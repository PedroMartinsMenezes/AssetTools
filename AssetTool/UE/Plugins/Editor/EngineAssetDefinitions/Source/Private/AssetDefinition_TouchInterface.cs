namespace AssetTool
{
    [JsonAsset("AssetDefinition_TouchInterface")]
    public class UAssetDefinition_TouchInterface : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}