namespace AssetTool
{
    [JsonAsset("PCGAddTagSettings")]
    public class UPCGAddTagSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}