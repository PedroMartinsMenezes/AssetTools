namespace AssetTool
{
    [JsonAsset("MassMovingAvoidanceProcessor")]
    public class UMassMovingAvoidanceProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassStandingAvoidanceProcessor")]
    public class UMassStandingAvoidanceProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}