namespace AssetTool
{
    [JsonAsset("ObjectElementEditorSelectionInterface")]
    public class UObjectElementEditorSelectionInterface : UObjectElementSelectionInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}