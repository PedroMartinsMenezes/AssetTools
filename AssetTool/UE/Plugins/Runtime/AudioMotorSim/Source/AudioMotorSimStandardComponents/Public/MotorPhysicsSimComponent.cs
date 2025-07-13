namespace AssetTool
{
    [JsonAsset("MotorPhysicsSimComponent")]
    public class UMotorPhysicsSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}