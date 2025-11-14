namespace AssetTool
{
    [JsonAsset("GizmoBaseTransformSource")]
    public class UGizmoBaseTransformSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoComponentWorldTransformSource")]
    public class UGizmoComponentWorldTransformSource : UGizmoBaseTransformSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoScaledTransformSource")]
    public class UGizmoScaledTransformSource : UGizmoBaseTransformSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoTransformProxyTransformSource")]
    public class UGizmoTransformProxyTransformSource : UGizmoBaseTransformSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoScaledAndUnscaledTransformSources")]
    public class UGizmoScaledAndUnscaledTransformSources : UGizmoBaseTransformSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}