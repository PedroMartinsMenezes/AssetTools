namespace AssetTool
{
    [JsonAsset("ScreenshotFunctionalTestBase")]
    public class AScreenshotFunctionalTestBase : AFunctionalTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}