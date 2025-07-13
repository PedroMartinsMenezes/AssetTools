namespace AssetTool
{
    [JsonAsset("UsdStageImportFactory")]
    public class UUsdStageImportFactory : USceneImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}