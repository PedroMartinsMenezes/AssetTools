namespace AssetTool
{
    [JsonAsset("PCGProjectionSettings")]
    public class UPCGProjectionSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}