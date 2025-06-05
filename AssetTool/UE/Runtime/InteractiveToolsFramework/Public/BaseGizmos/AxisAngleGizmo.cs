namespace AssetTool
{
    [JsonAsset("AxisAngleGizmoBuilder")]
    public class UAxisAngleGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisAngleGizmo")]
    public class UAxisAngleGizmo : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}