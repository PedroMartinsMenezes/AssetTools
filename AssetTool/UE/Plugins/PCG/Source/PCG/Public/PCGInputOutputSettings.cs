namespace AssetTool
{
    [JsonAsset("PCGGraphInputOutputSettings")]
    public class UPCGGraphInputOutputSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}