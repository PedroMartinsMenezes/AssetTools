namespace AssetTool
{
    [JsonAsset("PCGComputeGraphSettings")]
    public class UPCGComputeGraphSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}