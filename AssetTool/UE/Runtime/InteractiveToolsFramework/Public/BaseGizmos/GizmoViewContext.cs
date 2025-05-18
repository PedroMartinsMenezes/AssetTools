namespace AssetTool
{
    [JsonAsset("GizmoViewContext")]
    public class UGizmoViewContext : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}