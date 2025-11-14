namespace AssetTool
{
    [JsonAsset("ComponentElementEditorSelectionInterface")]
    public class UComponentElementEditorSelectionInterface : UComponentElementSelectionInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}