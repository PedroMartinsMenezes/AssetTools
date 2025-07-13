namespace AssetTool
{
    [JsonAsset("PointLightGizmoBuilder")]
    public class UPointLightGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PointLightGizmo")]
    public class UPointLightGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}