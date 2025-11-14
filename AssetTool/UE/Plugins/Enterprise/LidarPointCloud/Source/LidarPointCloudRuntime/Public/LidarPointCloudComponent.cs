namespace AssetTool
{
    [JsonAsset("LidarPointCloudComponent")]
    public class ULidarPointCloudComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}