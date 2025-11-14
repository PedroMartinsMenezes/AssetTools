namespace AssetTool
{
    [JsonAsset("PCGBadOutputsNodeSettings")]
    public class UPCGBadOutputsNodeSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}