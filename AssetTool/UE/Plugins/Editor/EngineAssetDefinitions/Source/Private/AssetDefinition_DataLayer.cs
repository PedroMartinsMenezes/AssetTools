namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataLayer")]
    public class UAssetDefinition_DataLayer : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}