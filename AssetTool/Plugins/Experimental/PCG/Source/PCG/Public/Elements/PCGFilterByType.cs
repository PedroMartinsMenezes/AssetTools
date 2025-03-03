namespace AssetTool
{
    [JsonAsset("PCGFilterByTypeSettings")]
    public class UPCGFilterByTypeSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}