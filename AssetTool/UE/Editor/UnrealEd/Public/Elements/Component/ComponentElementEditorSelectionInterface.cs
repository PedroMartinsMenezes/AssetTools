namespace AssetTool
{
    [JsonAsset("ComponentElementEditorSelectionInterface")]
    public class UComponentElementEditorSelectionInterface : UComponentElementSelectionInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}