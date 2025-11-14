namespace AssetTool
{
    [JsonAsset("AssetDefinition_TakePreset")]
    public class UAssetDefinition_TakePreset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}