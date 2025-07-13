namespace AssetTool
{
    [JsonAsset("AssetDefinition_ExternalDataLayer")]
    public class UAssetDefinition_ExternalDataLayer : UAssetDefinition_DataLayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}