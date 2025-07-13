namespace AssetTool
{
    [JsonAsset("SoundscapeSettings")]
    public class USoundscapeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}