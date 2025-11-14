namespace AssetTool
{
    [JsonAsset("UsdStageEditorSettings")]
    public class UUsdStageEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}