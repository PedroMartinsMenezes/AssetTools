namespace AssetTool
{
    [JsonAsset("TransformGizmo")]
    public class UTransformGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}