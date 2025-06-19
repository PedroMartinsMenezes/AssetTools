namespace AssetTool
{
    [JsonAsset("CrashReportsPrivacySettings")]
    public class UCrashReportsPrivacySettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}