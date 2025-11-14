namespace AssetTool
{
    [JsonAsset("SMInstanceElementEditorWorldInterface")]
    public class USMInstanceElementEditorWorldInterface : USMInstanceElementWorldInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}