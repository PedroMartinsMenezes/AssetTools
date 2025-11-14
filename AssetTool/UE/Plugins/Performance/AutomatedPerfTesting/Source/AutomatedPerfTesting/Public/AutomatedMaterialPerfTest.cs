namespace AssetTool
{
    [JsonAsset("AutomatedMaterialPerfTestProjectSettings")]
    public class UAutomatedMaterialPerfTestProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomatedMaterialPerfTest")]
    public class UAutomatedMaterialPerfTest : UAutomatedPerfTestControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}