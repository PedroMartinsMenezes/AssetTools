namespace AssetTool
{
    [JsonAsset("BoostMotorSimComponent")]
    public class UBoostMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}