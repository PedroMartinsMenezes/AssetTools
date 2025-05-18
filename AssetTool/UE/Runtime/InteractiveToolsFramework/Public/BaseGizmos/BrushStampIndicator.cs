namespace AssetTool
{
    [JsonAsset("BrushStampIndicatorBuilder")]
    public class UBrushStampIndicatorBuilder : UInteractiveGizmoBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BrushStampIndicator")]
    public class UBrushStampIndicator : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}