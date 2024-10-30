namespace AssetTool
{
    [JsonAsset("ObjectElementEditorSelectionInterface")]
    public class UObjectElementEditorSelectionInterface : UObjectElementSelectionInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}