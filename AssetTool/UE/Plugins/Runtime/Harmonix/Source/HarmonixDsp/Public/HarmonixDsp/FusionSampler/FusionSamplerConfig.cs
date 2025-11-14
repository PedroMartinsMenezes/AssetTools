namespace AssetTool
{
    [JsonAsset("FusionSamplerConfig")]
    public class UFusionSamplerConfig : UHarmonixDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}