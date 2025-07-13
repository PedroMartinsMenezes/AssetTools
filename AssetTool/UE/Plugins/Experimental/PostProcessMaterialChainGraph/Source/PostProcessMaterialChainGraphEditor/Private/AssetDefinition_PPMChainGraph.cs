namespace AssetTool
{
    [JsonAsset("AssetDefinition_PPMChainGraph")]
    public class UAssetDefinition_PPMChainGraph : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}