namespace AssetTool
{
    [JsonAsset("EditorTransformGizmoContextObject")]
    public class UEditorTransformGizmoContextObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}