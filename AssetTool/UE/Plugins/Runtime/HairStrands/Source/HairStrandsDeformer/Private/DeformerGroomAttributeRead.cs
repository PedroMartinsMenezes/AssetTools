namespace AssetTool
{
    [JsonAsset("OptimusGroomAttributeReadDataInterface")]
    public class UOptimusGroomAttributeReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomAttributeReadDataProvider")]
    public class UOptimusGroomAttributeReadDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}