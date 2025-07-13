namespace AssetTool
{
    [JsonAsset("RevisionControlDataStorageFactory")]
    public class URevisionControlDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}