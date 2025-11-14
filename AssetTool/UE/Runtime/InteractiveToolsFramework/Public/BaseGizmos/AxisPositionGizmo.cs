namespace AssetTool
{
    [JsonAsset("AxisPositionGizmoBuilder")]
    public class UAxisPositionGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisPositionGizmo")]
    public class UAxisPositionGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}