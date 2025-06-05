namespace AssetTool
{
    [JsonAsset("IntervalGizmoActor")]
    public class AIntervalGizmoActor : AGizmoActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IntervalGizmoBuilder")]
    public class UIntervalGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IntervalGizmo")]
    public class UIntervalGizmo : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoAxisIntervalParameterSource")]
    public class UGizmoAxisIntervalParameterSource : UGizmoBaseFloatParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}