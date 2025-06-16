namespace AssetTool
{
    [JsonAsset("PCGDebugSettings")]
    public class UPCGDebugSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}