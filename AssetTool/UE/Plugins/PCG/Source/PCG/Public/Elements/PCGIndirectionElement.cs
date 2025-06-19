namespace AssetTool
{
    [JsonAsset("PCGIndirectionSettings")]
    public class UPCGIndirectionSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}