namespace AssetTool
{
    [JsonAsset("RevisionControlDataStorageFactory")]
    public class URevisionControlDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}