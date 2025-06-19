namespace AssetTool
{
    [JsonAsset("AssetDefinition_FleshAsset")]
    public class UAssetDefinition_FleshAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}