namespace AssetTool
{
    [JsonAsset("GizmoElementRectangle")]
    public class UGizmoElementRectangle : UGizmoElementLineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}