namespace AssetTool
{
    [JsonAsset("PCGGatherSettings")]
    public class UPCGGatherSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}