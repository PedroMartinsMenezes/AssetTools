namespace AssetTool
{
    [JsonAsset("SpotLightGizmoBuilder")]
    public class USpotLightGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpotLightGizmoActor")]
    public class ASpotLightGizmoActor : AGizmoActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpotLightGizmo")]
    public class USpotLightGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpotLightGizmoInputBehavior")]
    public class USpotLightGizmoInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}