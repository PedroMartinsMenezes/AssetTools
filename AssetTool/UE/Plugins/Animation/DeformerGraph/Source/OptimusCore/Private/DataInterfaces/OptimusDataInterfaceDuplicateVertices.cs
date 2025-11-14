namespace AssetTool
{
    [JsonAsset("OptimusDuplicateVerticesDataInterface")]
    public class UOptimusDuplicateVerticesDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDuplicateVerticesDataProvider")]
    public class UOptimusDuplicateVerticesDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}