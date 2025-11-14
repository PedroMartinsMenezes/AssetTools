namespace AssetTool
{
    [JsonAsset("RevLimiterMotorSimComponent")]
    public class URevLimiterMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}