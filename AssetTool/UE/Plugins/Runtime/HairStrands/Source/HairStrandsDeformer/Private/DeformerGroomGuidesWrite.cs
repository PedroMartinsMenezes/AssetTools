namespace AssetTool
{
    [JsonAsset("OptimusGroomGuidesWriteDataInterface")]
    public class UOptimusGroomGuidesWriteDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomGuidesWriteDataProvider")]
    public class UOptimusGroomGuidesWriteDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}