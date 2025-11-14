namespace AssetTool
{
    [JsonAsset("ScreenshotFunctionalTest")]
    public class AScreenshotFunctionalTest : AScreenshotFunctionalTestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}