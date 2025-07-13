namespace AssetTool
{
    [JsonAsset("AutomationTestExcludelistSettings")]
    public class UAutomationTestExcludelistSettings : UAutomationTestPlatformSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomationTestExcludelistConfig")]
    public class UAutomationTestExcludelistConfig : UAutomationTestPlatformSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomationTestExcludelist")]
    public class UAutomationTestExcludelist : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}