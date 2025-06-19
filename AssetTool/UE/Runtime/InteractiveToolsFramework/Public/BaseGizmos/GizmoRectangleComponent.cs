namespace AssetTool
{
    [JsonAsset("GizmoRectangleComponent")]
    public class UGizmoRectangleComponent : UGizmoBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}