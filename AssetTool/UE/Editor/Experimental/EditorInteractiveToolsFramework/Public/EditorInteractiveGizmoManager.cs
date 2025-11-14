namespace AssetTool
{
    [JsonAsset("EditorInteractiveGizmoManager")]
    public class UEditorInteractiveGizmoManager : UInteractiveGizmoManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}