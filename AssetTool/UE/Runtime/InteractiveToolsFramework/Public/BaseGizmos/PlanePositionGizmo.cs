namespace AssetTool
{
    [JsonAsset("PlanePositionGizmoBuilder")]
    public class UPlanePositionGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlanePositionGizmo")]
    public class UPlanePositionGizmo : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}