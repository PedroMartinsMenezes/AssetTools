namespace AssetTool
{
    [JsonAsset("GizmoArrowComponent")]
    public class UGizmoArrowComponent : UGizmoBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}