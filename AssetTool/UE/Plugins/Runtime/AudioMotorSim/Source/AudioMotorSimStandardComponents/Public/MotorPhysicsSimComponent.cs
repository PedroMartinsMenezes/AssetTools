namespace AssetTool
{
    [JsonAsset("MotorPhysicsSimComponent")]
    public class UMotorPhysicsSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}