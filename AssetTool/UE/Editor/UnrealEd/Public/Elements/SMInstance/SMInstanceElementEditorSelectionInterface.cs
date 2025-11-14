namespace AssetTool
{
    [JsonAsset("SMInstanceElementEditorSelectionInterface")]
    public class USMInstanceElementEditorSelectionInterface : USMInstanceElementSelectionInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}