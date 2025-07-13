namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataAsset")]
    public class UAssetDefinition_DataAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}