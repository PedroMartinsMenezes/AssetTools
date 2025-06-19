namespace AssetTool
{
    [JsonAsset("AnalogSlider")]
    public class UAnalogSlider : USlider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}