namespace AssetTool
{
    [JsonAsset("AxisPositionGizmoBuilder")]
    public class UAxisPositionGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisPositionGizmo")]
    public class UAxisPositionGizmo : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}