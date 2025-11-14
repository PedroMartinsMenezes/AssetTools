namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoBuilder")]
    public class UEditorTransformGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}