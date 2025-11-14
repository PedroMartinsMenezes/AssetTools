namespace AssetTool
{
    [JsonAsset("GizmoViewContext")]
    public class UGizmoViewContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}