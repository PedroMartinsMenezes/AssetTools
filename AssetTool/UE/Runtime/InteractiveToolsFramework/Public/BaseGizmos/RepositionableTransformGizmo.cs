namespace AssetTool
{
    [JsonAsset("RepositionableTransformGizmoBuilder")]
    public class URepositionableTransformGizmoBuilder : UCombinedTransformGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RepositionableTransformGizmo")]
    public class URepositionableTransformGizmo : UCombinedTransformGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}