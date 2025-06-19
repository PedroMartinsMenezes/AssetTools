namespace AssetTool
{
    [JsonAsset("PCGDensityFilterSettings")]
    public class UPCGDensityFilterSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}