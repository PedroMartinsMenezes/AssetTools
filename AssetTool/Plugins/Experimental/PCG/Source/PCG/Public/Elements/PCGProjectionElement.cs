namespace AssetTool
{
    [JsonAsset("PCGProjectionSettings")]
    public class UPCGProjectionSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}