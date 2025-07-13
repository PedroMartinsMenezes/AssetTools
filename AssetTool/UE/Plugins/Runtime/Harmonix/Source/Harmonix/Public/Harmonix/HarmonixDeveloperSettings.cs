namespace AssetTool
{
    [JsonAsset("HarmonixDeveloperSettings")]
    public class UHarmonixDeveloperSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}