namespace AssetTool
{
    [JsonAsset("OptimusGroomMeshesReadDataInterface")]
    public class UOptimusGroomMeshesReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomMeshesReadDataProvider")]
    public class UOptimusGroomMeshesReadDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}