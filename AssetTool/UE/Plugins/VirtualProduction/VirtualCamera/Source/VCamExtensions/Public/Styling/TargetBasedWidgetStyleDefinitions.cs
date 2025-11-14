namespace AssetTool
{
    [JsonAsset("TargetBasedWidgetStyleDefinitions")]
    public class UTargetBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}