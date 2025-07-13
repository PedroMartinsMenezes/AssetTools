namespace AssetTool
{
    [JsonAsset("EditorInteractiveGizmoManager")]
    public class UEditorInteractiveGizmoManager : UInteractiveGizmoManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}