namespace AssetTool
{
    [JsonAsset("GizmoElementCircle")]
    public class UGizmoElementCircle : UGizmoElementCircleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}