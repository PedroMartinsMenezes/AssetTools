namespace AssetTool
{
    [JsonAsset("MassSteerToMoveTargetProcessor")]
    public class UMassSteerToMoveTargetProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}