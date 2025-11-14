namespace AssetTool
{
    [JsonAsset("ReverseMotorSimComponent")]
    public class UReverseMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}