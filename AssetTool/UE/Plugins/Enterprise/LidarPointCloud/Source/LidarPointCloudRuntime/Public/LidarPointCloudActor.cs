namespace AssetTool
{
    [JsonAsset("LidarPointCloudActor")]
    public class ALidarPointCloudActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}