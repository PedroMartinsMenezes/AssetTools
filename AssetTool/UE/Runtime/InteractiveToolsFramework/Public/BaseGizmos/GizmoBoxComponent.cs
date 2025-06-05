namespace AssetTool
{
    [JsonAsset("GizmoBoxComponent")]
    public class UGizmoBoxComponent : UGizmoBaseComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}