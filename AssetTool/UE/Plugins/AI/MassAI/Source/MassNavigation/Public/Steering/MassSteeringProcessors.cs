namespace AssetTool
{
    [JsonAsset("MassSteerToMoveTargetProcessor")]
    public class UMassSteerToMoveTargetProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}