namespace AssetTool
{
    [JsonAsset("GizmoElementCircle")]
    public class UGizmoElementCircle : UGizmoElementCircleBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}