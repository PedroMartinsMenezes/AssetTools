namespace AssetTool
{
    [JsonAsset("SoundscapeSettings")]
    public class USoundscapeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}