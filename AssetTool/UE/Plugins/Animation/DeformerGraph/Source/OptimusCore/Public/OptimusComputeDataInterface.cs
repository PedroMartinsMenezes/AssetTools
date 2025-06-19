namespace AssetTool
{
    [JsonAsset("OptimusComputeDataInterface")]
    public class UOptimusComputeDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}