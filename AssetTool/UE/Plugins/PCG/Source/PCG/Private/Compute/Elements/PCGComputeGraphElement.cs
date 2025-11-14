namespace AssetTool
{
    [JsonAsset("PCGComputeGraphSettings")]
    public class UPCGComputeGraphSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}