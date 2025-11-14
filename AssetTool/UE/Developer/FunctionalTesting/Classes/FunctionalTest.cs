namespace AssetTool
{
    [JsonAsset("AutomationPerformaceHelper")]
    public class UAutomationPerformaceHelper : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FunctionalTest")]
    public class AFunctionalTest : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}