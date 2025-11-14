namespace AssetTool
{
    [JsonAsset("ScalableSphereGizmoBuilder")]
    public class UScalableSphereGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScalableSphereGizmo")]
    public class UScalableSphereGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScalableSphereGizmoInputBehavior")]
    public class UScalableSphereGizmoInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}