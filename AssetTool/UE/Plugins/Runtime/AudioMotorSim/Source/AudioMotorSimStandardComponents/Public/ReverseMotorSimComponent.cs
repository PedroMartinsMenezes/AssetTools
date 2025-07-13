namespace AssetTool
{
    [JsonAsset("ReverseMotorSimComponent")]
    public class UReverseMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}