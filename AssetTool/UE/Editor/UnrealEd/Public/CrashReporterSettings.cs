namespace AssetTool
{
    [JsonAsset("CrashReporterSettings")]
    public class UCrashReporterSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}