namespace AssetTool
{
    [JsonAsset("PCGComputeDataInterface")]
    public class UPCGComputeDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}