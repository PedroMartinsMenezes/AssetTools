namespace AssetTool
{
    [JsonAsset("AudioSliderBase")]
    public class UAudioSliderBase : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioSlider")]
    public class UAudioSlider : UAudioSliderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioVolumeSlider")]
    public class UAudioVolumeSlider : UAudioSlider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioFrequencySlider")]
    public class UAudioFrequencySlider : UAudioSliderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}