namespace AssetTool
{
    [JsonAsset("PCGPrimitiveCrossSectionSettings")]
    public class UPCGPrimitiveCrossSectionSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}