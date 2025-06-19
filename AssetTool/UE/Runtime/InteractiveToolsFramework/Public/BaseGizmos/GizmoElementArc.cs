namespace AssetTool
{
    [JsonAsset("GizmoElementArc")]
    public class UGizmoElementArc : UGizmoElementCircleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}