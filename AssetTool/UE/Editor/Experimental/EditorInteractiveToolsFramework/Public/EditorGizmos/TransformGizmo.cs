namespace AssetTool
{
    [JsonAsset("TransformGizmo")]
    public class UTransformGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}