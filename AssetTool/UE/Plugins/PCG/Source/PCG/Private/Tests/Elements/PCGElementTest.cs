namespace AssetTool
{
    [JsonAsset("PCGBadOutputsNodeSettings")]
    public class UPCGBadOutputsNodeSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}