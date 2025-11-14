namespace AssetTool
{
    [JsonAsset("AudioRadialSlider")]
    public class UAudioRadialSlider : UWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioVolumeRadialSlider")]
    public class UAudioVolumeRadialSlider : UAudioRadialSlider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioFrequencyRadialSlider")]
    public class UAudioFrequencyRadialSlider : UAudioRadialSlider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}