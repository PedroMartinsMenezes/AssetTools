namespace AssetTool
{
    [JsonAsset("PCGGenerateSeedSettings")]
    public class UPCGGenerateSeedSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}