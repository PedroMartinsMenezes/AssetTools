namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanConfig")]
    public class UAssetDefinition_MetaHumanConfig : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}