namespace AssetTool
{
    [JsonAsset("SMInstanceElementEditorSelectionInterface")]
    public class USMInstanceElementEditorSelectionInterface : USMInstanceElementSelectionInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}