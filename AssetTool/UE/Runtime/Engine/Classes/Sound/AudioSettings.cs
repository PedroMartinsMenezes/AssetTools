namespace AssetTool
{
    [JsonAsset("AudioSettings")]
    public class UAudioSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}