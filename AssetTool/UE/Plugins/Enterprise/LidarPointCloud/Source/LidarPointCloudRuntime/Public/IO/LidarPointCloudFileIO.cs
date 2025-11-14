namespace AssetTool
{
    [JsonAsset("LidarPointCloudFileIO")]
    public class ULidarPointCloudFileIO : UExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}