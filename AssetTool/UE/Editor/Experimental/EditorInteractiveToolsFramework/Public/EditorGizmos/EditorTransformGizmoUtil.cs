namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoContextObject")]
    public class UEditorTransformGizmoContextObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}