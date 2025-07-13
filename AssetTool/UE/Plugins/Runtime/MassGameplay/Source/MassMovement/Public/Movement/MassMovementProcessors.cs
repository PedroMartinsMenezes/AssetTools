namespace AssetTool
{
    [JsonAsset("MassApplyMovementProcessor")]
    public class UMassApplyMovementProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}