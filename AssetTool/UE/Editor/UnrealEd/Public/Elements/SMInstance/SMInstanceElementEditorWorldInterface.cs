namespace AssetTool
{
    [JsonAsset("SMInstanceElementEditorWorldInterface")]
    public class USMInstanceElementEditorWorldInterface : USMInstanceElementWorldInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}