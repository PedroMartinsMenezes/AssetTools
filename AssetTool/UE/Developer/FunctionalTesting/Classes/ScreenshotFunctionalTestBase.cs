namespace AssetTool
{
    [JsonAsset("ScreenshotFunctionalTestBase")]
    public class AScreenshotFunctionalTestBase : AFunctionalTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}