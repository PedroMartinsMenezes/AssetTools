namespace AssetTool
{
    [JsonAsset("SMInstanceElementEditorWorldInterface")]
    public class USMInstanceElementEditorWorldInterface : USMInstanceElementWorldInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}