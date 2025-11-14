namespace AssetTool
{
    [JsonAsset("MassApplyMovementProcessor")]
    public class UMassApplyMovementProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}