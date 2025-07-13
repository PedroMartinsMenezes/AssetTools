namespace AssetTool
{
    [JsonAsset("AssetDefinition_WidgetBlueprint")]
    public class UAssetDefinition_WidgetBlueprint : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}