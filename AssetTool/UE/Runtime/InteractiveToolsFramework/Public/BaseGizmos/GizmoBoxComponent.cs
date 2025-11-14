namespace AssetTool
{
    [JsonAsset("GizmoBoxComponent")]
    public class UGizmoBoxComponent : UGizmoBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}