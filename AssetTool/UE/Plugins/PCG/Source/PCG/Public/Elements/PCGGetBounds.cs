namespace AssetTool
{
    [JsonAsset("PCGGetBoundsSettings")]
    public class UPCGGetBoundsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}