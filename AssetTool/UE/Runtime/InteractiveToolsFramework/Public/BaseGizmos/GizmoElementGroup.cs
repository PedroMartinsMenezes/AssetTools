namespace AssetTool
{
    [JsonAsset("GizmoElementGroup")]
    public class UGizmoElementGroup : UGizmoElementLineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}