namespace AssetTool
{
    [JsonAsset("GizmoRectangleComponent")]
    public class UGizmoRectangleComponent : UGizmoBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}