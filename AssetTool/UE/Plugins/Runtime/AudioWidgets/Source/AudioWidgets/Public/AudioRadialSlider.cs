namespace AssetTool
{
    [JsonAsset("AudioRadialSlider")]
    public class UAudioRadialSlider : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioVolumeRadialSlider")]
    public class UAudioVolumeRadialSlider : UAudioRadialSlider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioFrequencyRadialSlider")]
    public class UAudioFrequencyRadialSlider : UAudioRadialSlider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}