namespace AssetTool
{
    [JsonAsset("RpmCurveMotorSimComponent")]
    public class URpmCurveMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}