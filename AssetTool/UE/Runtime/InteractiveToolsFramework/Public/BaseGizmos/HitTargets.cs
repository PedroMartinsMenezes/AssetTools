namespace AssetTool
{
    [JsonAsset("GizmoLambdaHitTarget")]
    public class UGizmoLambdaHitTarget : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoComponentHitTarget")]
    public class UGizmoComponentHitTarget : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}