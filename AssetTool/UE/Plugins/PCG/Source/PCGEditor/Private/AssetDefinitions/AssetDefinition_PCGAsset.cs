namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGAsset")]
    public class UAssetDefinition_PCGAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}