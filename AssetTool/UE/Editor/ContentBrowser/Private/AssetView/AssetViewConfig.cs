namespace AssetTool
{
    [JsonAsset("AssetViewConfig")]
    public class UAssetViewConfig : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}