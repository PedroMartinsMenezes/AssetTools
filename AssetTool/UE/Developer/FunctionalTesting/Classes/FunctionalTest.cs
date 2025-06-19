namespace AssetTool
{
    [JsonAsset("AutomationPerformaceHelper")]
    public class UAutomationPerformaceHelper : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FunctionalTest")]
    public class AFunctionalTest : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}