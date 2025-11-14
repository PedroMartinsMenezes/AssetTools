namespace AssetTool
{
    [JsonAsset("GizmoElementRectangle")]
    public class UGizmoElementRectangle : UGizmoElementLineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}