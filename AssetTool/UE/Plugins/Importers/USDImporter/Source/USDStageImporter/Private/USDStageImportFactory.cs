namespace AssetTool
{
    [JsonAsset("UsdStageImportFactory")]
    public class UUsdStageImportFactory : USceneImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}