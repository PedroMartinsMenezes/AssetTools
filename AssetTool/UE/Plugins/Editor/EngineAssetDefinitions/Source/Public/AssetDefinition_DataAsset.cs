namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataAsset")]
    public class UAssetDefinition_DataAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}