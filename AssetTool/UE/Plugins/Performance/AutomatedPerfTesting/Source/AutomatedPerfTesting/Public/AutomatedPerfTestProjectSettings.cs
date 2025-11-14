namespace AssetTool
{
    [JsonAsset("AutomatedPerfTestProjectSettings")]
    public class UAutomatedPerfTestProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}