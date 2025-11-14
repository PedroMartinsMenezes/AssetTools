namespace AssetTool
{
    [JsonAsset("PointLightGizmoBuilder")]
    public class UPointLightGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PointLightGizmo")]
    public class UPointLightGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}