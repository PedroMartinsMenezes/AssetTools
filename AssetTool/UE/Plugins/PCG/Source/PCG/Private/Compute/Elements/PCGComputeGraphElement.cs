namespace AssetTool
{
    [JsonAsset("PCGComputeGraphSettings")]
    public class UPCGComputeGraphSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}