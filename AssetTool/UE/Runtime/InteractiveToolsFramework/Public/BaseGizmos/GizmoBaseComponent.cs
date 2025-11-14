namespace AssetTool
{
    [JsonAsset("GizmoBaseComponent")]
    public class UGizmoBaseComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}