namespace AssetTool
{
    [JsonAsset("AssetViewConfig")]
    public class UAssetViewConfig : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}