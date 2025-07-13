namespace AssetTool
{
    [JsonAsset("AssetDefinition_GroomBindingAsset")]
    public class UAssetDefinition_GroomBindingAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}