namespace AssetTool
{
    [JsonAsset("OptimusComputeDataInterface")]
    public class UOptimusComputeDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}