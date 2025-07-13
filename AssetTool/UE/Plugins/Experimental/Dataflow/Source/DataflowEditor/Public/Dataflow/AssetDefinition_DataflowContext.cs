namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataflowContext")]
    public class UAssetDefinition_DataflowContext : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}