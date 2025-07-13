namespace AssetTool
{
    [JsonAsset("SoundCueTemplateSettings")]
    public class USoundCueTemplateSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}