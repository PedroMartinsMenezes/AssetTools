namespace AssetTool
{
    [JsonAsset("TedsAssetDataFactory")]
    public class UTedsAssetDataFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}