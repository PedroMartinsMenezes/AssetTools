namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataflowAsset")]
    public class UAssetDefinition_DataflowAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}