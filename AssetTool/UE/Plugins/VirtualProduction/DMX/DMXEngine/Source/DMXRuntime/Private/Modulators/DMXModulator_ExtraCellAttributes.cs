namespace AssetTool
{
    [JsonAsset("DMXModulator_ExtraCellAttributes")]
    public class UDMXModulator_ExtraCellAttributes : UDMXModulator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}