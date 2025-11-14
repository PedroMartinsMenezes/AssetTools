namespace AssetTool
{
    [JsonAsset("SoundCueTemplateSettings")]
    public class USoundCueTemplateSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}