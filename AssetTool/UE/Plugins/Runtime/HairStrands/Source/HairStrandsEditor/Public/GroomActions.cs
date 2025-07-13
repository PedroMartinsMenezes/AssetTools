namespace AssetTool
{
    [JsonAsset("AssetDefinition_GroomAsset")]
    public class UAssetDefinition_GroomAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}