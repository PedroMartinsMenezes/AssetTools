namespace AssetTool
{
    [JsonAsset("AssetDataLabelWidgetFactory")]
    public class UAssetDataLabelWidgetFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}