namespace AssetTool
{
    [JsonAsset("ThrottleStateMotorSimComponent")]
    public class UThrottleStateMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}