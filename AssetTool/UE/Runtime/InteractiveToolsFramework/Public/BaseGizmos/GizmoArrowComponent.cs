namespace AssetTool
{
    [JsonAsset("GizmoArrowComponent")]
    public class UGizmoArrowComponent : UGizmoBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}