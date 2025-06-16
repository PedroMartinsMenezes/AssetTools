namespace AssetTool
{
    [JsonAsset("PCGBadOutputsNodeSettings")]
    public class UPCGBadOutputsNodeSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}