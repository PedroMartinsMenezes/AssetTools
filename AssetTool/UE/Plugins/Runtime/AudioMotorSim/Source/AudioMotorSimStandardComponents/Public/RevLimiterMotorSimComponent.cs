namespace AssetTool
{
    [JsonAsset("RevLimiterMotorSimComponent")]
    public class URevLimiterMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}