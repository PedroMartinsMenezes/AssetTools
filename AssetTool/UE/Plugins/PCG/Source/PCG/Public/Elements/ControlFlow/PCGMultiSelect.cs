namespace AssetTool
{
    [JsonAsset("PCGMultiSelectSettings")]
    public class UPCGMultiSelectSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}