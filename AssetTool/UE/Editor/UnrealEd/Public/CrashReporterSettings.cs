namespace AssetTool
{
    [JsonAsset("CrashReporterSettings")]
    public class UCrashReporterSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}