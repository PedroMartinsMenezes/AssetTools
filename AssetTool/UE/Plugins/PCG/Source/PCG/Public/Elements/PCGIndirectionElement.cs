namespace AssetTool
{
    [JsonAsset("PCGIndirectionSettings")]
    public class UPCGIndirectionSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}