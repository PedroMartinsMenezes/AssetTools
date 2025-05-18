namespace AssetTool
{
    [JsonAsset("GizmoBaseComponent")]
    public class UGizmoBaseComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}