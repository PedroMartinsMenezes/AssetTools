namespace AssetTool
{
    [JsonAsset("VelocitySyncMotorSimComponent")]
    public class UVelocitySyncMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}