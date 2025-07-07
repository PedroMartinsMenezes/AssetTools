namespace AssetTool
{
    [JsonAsset("DMXModulator_ExtraAttributes")]
    public class UDMXModulator_ExtraAttributes : UDMXModulator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}