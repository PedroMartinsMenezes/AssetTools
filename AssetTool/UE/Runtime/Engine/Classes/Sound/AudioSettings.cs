namespace AssetTool
{
    [JsonAsset("AudioSettings")]
    public class UAudioSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}