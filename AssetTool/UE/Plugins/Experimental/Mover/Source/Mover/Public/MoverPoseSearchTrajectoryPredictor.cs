namespace AssetTool
{
    [JsonAsset("MoverTrajectoryPredictor")]
    public class UMoverTrajectoryPredictor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}