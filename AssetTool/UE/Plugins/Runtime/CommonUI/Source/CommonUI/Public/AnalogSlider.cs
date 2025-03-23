namespace AssetTool
{
    [JsonAsset("AnalogSlider")]
    public class UAnalogSlider : USlider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}