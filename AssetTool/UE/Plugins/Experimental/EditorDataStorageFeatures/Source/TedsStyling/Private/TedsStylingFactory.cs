namespace AssetTool
{
    [JsonAsset("TedsStylingFactory")]
    public class UTedsStylingFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}