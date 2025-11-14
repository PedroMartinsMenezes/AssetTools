namespace AssetTool
{
    [JsonAsset("XRCreativeGizmoBuilder")]
    public class UXRCreativeGizmoBuilder : UCombinedTransformGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeGizmo")]
    public class UXRCreativeGizmo : UCombinedTransformGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeCombinedTransformGizmoActor")]
    public class AXRCreativeCombinedTransformGizmoActor : ACombinedTransformGizmoActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeGizmoMeshComponent")]
    public class UXRCreativeGizmoMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}