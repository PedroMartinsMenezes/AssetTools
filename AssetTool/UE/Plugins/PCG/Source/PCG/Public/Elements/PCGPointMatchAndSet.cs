namespace AssetTool
{
    [JsonAsset("PCGPointMatchAndSetSettings")]
    public class UPCGPointMatchAndSetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}