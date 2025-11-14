namespace AssetTool
{
    [JsonAsset("IntervalGizmoActor")]
    public class AIntervalGizmoActor : AGizmoActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IntervalGizmoBuilder")]
    public class UIntervalGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IntervalGizmo")]
    public class UIntervalGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoAxisIntervalParameterSource")]
    public class UGizmoAxisIntervalParameterSource : UGizmoBaseFloatParameterSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}