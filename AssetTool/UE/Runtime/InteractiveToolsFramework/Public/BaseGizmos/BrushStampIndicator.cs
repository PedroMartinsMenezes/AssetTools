namespace AssetTool
{
    [JsonAsset("BrushStampIndicatorBuilder")]
    public class UBrushStampIndicatorBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BrushStampIndicator")]
    public class UBrushStampIndicator : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}