namespace AssetTool
{
    [JsonAsset("GizmoBoxComponent")]
    public class UGizmoBoxComponent : UGizmoBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}