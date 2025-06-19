namespace AssetTool
{
    [JsonAsset("FunctionalUIScreenshotTest")]
    public class AFunctionalUIScreenshotTest : AScreenshotFunctionalTestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}