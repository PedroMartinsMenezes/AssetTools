namespace AssetTool
{
    [JsonAsset("ClassBasedWidgetStyleDefinitions")]
    public class UClassBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}