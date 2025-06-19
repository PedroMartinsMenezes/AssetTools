namespace AssetTool
{
    [JsonAsset("GizmoLineHandleComponent")]
    public class UGizmoLineHandleComponent : UGizmoBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}