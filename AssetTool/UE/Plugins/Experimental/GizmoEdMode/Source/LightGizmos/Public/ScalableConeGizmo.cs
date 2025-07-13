namespace AssetTool
{
    [JsonAsset("ScalableConeGizmoBuilder")]
    public class UScalableConeGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScalableConeGizmo")]
    public class UScalableConeGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScalableConeGizmoInputBehavior")]
    public class UScalableConeGizmoInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}