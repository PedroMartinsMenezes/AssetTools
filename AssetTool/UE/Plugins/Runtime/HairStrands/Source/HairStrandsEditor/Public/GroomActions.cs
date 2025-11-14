namespace AssetTool
{
    [JsonAsset("AssetDefinition_GroomAsset")]
    public class UAssetDefinition_GroomAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}