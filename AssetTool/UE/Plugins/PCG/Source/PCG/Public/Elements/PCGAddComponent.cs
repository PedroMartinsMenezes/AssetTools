namespace AssetTool
{
    [JsonAsset("PCGAddComponentSettings")]
    public class UPCGAddComponentSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}