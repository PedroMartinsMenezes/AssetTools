namespace AssetTool
{
    [JsonAsset("DirectionalLightGizmoBuilder")]
    public class UDirectionalLightGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DirectionalLightGizmoActor")]
    public class ADirectionalLightGizmoActor : AGizmoActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DirectionalLightGizmo")]
    public class UDirectionalLightGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DirectionalLightGizmoInputBehavior")]
    public class UDirectionalLightGizmoInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}