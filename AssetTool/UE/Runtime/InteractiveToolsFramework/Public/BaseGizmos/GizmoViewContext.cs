namespace AssetTool
{
    [JsonAsset("GizmoViewContext")]
    public class UGizmoViewContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}