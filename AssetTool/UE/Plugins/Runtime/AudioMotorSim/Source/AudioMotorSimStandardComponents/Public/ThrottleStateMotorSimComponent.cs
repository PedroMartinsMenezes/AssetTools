namespace AssetTool
{
    [JsonAsset("ThrottleStateMotorSimComponent")]
    public class UThrottleStateMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}