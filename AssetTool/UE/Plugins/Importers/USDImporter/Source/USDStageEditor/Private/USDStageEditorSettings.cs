namespace AssetTool
{
    [JsonAsset("UsdStageEditorSettings")]
    public class UUsdStageEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}