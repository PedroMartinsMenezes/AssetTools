namespace AssetTool
{
    [JsonAsset("RpmCurveMotorSimComponent")]
    public class URpmCurveMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}