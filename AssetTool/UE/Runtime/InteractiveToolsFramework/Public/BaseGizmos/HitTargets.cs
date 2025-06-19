namespace AssetTool
{
    [JsonAsset("GizmoLambdaHitTarget")]
    public class UGizmoLambdaHitTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoComponentHitTarget")]
    public class UGizmoComponentHitTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}