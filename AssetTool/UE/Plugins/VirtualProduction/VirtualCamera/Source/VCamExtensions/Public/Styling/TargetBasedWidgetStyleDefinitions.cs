namespace AssetTool
{
    [JsonAsset("TargetBasedWidgetStyleDefinitions")]
    public class UTargetBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}