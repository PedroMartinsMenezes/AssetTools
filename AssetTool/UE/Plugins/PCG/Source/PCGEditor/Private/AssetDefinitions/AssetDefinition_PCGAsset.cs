namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGAsset")]
    public class UAssetDefinition_PCGAsset : UAssetDefinitionDefault
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}