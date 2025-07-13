namespace AssetTool
{
    [JsonAsset("InteractiveToolsPresetCollectionAsset")]
    public class UInteractiveToolsPresetCollectionAsset : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveToolsPresetCollectionAssetFactory")]
    public class UInteractiveToolsPresetCollectionAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}