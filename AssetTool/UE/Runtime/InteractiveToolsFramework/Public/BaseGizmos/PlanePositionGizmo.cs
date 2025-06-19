namespace AssetTool
{
    [JsonAsset("PlanePositionGizmoBuilder")]
    public class UPlanePositionGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlanePositionGizmo")]
    public class UPlanePositionGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}