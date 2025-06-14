namespace AssetTool
{
    [JsonAsset("MoverTrajectoryPredictor")]
    public class UMoverTrajectoryPredictor : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}