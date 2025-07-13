namespace AssetTool
{
    [JsonAsset("AssetDefinition_TemplateSequence")]
    public class UAssetDefinition_TemplateSequence : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}