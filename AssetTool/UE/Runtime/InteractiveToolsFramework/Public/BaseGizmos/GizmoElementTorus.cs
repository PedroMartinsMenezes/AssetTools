namespace AssetTool
{
    [JsonAsset("GizmoElementTorus")]
    public class UGizmoElementTorus : UGizmoElementCircleBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}