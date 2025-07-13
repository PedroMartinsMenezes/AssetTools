namespace AssetTool
{
    [JsonAsset("AutomatedMaterialPerfTestProjectSettings")]
    public class UAutomatedMaterialPerfTestProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomatedMaterialPerfTest")]
    public class UAutomatedMaterialPerfTest : UAutomatedPerfTestControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}