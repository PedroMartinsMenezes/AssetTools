namespace AssetTool
{
    [JsonAsset("GizmoElementHitTarget")]
    public class UGizmoElementHitTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoElementHitMultiTarget")]
    public class UGizmoElementHitMultiTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}