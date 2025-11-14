namespace AssetTool
{
    [JsonAsset("PCGDifferenceSettings")]
    public class UPCGDifferenceSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}