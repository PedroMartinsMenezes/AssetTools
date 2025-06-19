namespace AssetTool
{
    [JsonAsset("GizmoBaseComponent")]
    public class UGizmoBaseComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}