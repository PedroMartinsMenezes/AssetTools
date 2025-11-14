namespace AssetTool
{
    [JsonAsset("GizmoLineHandleComponent")]
    public class UGizmoLineHandleComponent : UGizmoBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}