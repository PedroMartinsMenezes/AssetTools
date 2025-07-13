namespace AssetTool
{
    [JsonAsset("BoostMotorSimComponent")]
    public class UBoostMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}