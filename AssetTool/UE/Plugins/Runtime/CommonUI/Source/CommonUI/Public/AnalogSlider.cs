namespace AssetTool
{
    [JsonAsset("AnalogSlider")]
    public class UAnalogSlider : USlider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}