namespace AssetTool
{
    [JsonAsset("GizmoElementGroup")]
    public class UGizmoElementGroup : UGizmoElementLineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}