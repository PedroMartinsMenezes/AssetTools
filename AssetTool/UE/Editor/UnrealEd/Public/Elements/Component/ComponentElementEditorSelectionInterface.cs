namespace AssetTool
{
    [JsonAsset("ComponentElementEditorSelectionInterface")]
    public class UComponentElementEditorSelectionInterface : UComponentElementSelectionInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}