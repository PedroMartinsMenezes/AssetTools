namespace AssetTool
{
    [JsonAsset("PCGDistanceSettings")]
    public class UPCGDistanceSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}