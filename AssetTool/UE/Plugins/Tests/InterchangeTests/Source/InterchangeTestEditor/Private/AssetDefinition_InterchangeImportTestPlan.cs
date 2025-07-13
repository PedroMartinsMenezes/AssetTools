namespace AssetTool
{
    [JsonAsset("AssetDefinition_InterchangeImportTestPlan")]
    public class UAssetDefinition_InterchangeImportTestPlan : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}