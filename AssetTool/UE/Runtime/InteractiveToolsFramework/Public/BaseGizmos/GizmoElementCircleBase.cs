namespace AssetTool
{
    [JsonAsset("GizmoElementCircleBase")]
    public class UGizmoElementCircleBase : UGizmoElementLineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}