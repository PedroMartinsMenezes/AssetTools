namespace AssetTool
{
    [JsonAsset("FunctionalUIScreenshotTest")]
    public class AFunctionalUIScreenshotTest : AScreenshotFunctionalTestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}