namespace AssetTool
{
    [JsonAsset("LidarPointCloudActor")]
    public class ALidarPointCloudActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}