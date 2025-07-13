namespace AssetTool
{
    [JsonAsset("AutomatedSequencePerfTestProjectSettings")]
    public class UAutomatedSequencePerfTestProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomatedSequencePerfTest")]
    public class UAutomatedSequencePerfTest : UAutomatedPerfTestControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}