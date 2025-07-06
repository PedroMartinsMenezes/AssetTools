namespace AssetTool
{
    [JsonAsset("XRCreativeGizmoBuilder")]
    public class UXRCreativeGizmoBuilder : UCombinedTransformGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeGizmo")]
    public class UXRCreativeGizmo : UCombinedTransformGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeCombinedTransformGizmoActor")]
    public class AXRCreativeCombinedTransformGizmoActor : ACombinedTransformGizmoActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeGizmoMeshComponent")]
    public class UXRCreativeGizmoMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}