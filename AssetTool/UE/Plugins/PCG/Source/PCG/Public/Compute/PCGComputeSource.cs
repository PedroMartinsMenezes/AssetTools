namespace AssetTool
{
    [JsonAsset("PCGComputeSource")]
    public class UPCGComputeSource : UComputeSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}