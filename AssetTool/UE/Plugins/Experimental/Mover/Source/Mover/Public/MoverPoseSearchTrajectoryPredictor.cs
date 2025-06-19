namespace AssetTool
{
    [JsonAsset("MoverTrajectoryPredictor")]
    public class UMoverTrajectoryPredictor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}