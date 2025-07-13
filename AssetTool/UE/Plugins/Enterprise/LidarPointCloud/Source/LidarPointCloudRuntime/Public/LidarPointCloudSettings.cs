namespace AssetTool
{
    [JsonAsset("LidarPointCloudSettings")]
    public class ULidarPointCloudSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}