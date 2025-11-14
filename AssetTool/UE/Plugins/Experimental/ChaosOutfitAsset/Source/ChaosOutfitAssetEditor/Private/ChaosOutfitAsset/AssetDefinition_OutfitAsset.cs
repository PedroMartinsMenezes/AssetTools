namespace AssetTool
{
    [JsonAsset("AssetDefinition_OutfitAsset")]
    public class UAssetDefinition_OutfitAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}