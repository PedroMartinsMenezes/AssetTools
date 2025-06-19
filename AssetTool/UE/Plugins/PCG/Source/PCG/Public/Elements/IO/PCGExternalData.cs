namespace AssetTool
{
    [JsonAsset("PCGExternalDataSettings")]
    public class UPCGExternalDataSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}