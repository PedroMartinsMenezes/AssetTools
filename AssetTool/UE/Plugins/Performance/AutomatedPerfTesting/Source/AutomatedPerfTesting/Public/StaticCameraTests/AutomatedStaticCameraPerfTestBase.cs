namespace AssetTool
{
    [JsonAsset("AutomatedStaticCameraPerfTestProjectSettings")]
    public class UAutomatedStaticCameraPerfTestProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomatedStaticCameraPerfTestBase")]
    public class UAutomatedStaticCameraPerfTestBase : UAutomatedPerfTestControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}