namespace AssetTool
{
    [JsonAsset("ScreenshotFunctionalTest")]
    public class AScreenshotFunctionalTest : AScreenshotFunctionalTestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}