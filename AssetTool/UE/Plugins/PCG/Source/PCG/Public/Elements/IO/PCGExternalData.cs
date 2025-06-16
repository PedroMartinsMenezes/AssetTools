namespace AssetTool
{
    [JsonAsset("PCGExternalDataSettings")]
    public class UPCGExternalDataSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}