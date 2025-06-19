namespace AssetTool
{
    [JsonAsset("CombinedTransformGizmoActor")]
    public class ACombinedTransformGizmoActor : AGizmoActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CombinedTransformGizmoBuilder")]
    public class UCombinedTransformGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CombinedTransformGizmo")]
    public class UCombinedTransformGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}