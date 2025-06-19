namespace AssetTool
{
    [JsonAsset("AxisPositionGizmoBuilder")]
    public class UAxisPositionGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisPositionGizmo")]
    public class UAxisPositionGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}