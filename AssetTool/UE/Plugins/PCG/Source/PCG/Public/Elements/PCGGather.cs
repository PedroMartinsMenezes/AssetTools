namespace AssetTool
{
    [JsonAsset("PCGGatherSettings")]
    public class UPCGGatherSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}