namespace AssetTool
{
    [JsonAsset("LidarPointCloud")]
    public class ULidarPointCloud : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarPointCloudBlueprintLibrary")]
    public class ULidarPointCloudBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarClippingVolume")]
    public class ALidarClippingVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}