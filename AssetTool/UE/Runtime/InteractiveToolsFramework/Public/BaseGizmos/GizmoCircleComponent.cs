namespace AssetTool
{
    [JsonAsset("GizmoCircleComponent")]
    public class UGizmoCircleComponent : UGizmoBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}