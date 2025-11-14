namespace AssetTool
{
    [JsonAsset("VelocitySyncMotorSimComponent")]
    public class UVelocitySyncMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}