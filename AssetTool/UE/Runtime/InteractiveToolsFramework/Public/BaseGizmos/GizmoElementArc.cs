namespace AssetTool
{
    [JsonAsset("GizmoElementArc")]
    public class UGizmoElementArc : UGizmoElementCircleBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}