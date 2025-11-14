namespace AssetTool
{
    [JsonAsset("InteractiveToolsPresetCollectionAsset")]
    public class UInteractiveToolsPresetCollectionAsset : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveToolsPresetCollectionAssetFactory")]
    public class UInteractiveToolsPresetCollectionAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}