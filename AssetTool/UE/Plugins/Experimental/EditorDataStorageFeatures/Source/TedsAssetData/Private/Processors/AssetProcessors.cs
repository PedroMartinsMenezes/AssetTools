namespace AssetTool
{
    [JsonAsset("TedsAssetDataFactory")]
    public class UTedsAssetDataFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}