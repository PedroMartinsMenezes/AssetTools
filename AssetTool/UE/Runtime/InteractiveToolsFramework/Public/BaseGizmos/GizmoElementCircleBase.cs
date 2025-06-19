namespace AssetTool
{
    [JsonAsset("GizmoElementCircleBase")]
    public class UGizmoElementCircleBase : UGizmoElementLineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}