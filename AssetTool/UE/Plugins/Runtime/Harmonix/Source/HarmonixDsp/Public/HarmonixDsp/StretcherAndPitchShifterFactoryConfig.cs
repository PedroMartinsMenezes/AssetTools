namespace AssetTool
{
    [JsonAsset("StretcherAndPitchShifterFactoryConfig")]
    public class UStretcherAndPitchShifterFactoryConfig : UHarmonixDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}