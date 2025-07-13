namespace AssetTool
{
    [JsonAsset("LidarPointCloudComponent")]
    public class ULidarPointCloudComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}