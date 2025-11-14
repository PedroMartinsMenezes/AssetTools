namespace AssetTool
{
    [JsonAsset("AssetDefinition_PPMChainGraph")]
    public class UAssetDefinition_PPMChainGraph : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}