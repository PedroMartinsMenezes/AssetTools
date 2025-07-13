namespace AssetTool
{
    [JsonAsset("PCGPrimitiveCrossSectionSettings")]
    public class UPCGPrimitiveCrossSectionSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}