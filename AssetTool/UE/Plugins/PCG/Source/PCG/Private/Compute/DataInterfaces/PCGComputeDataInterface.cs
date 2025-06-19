namespace AssetTool
{
    [JsonAsset("PCGComputeDataInterface")]
    public class UPCGComputeDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}