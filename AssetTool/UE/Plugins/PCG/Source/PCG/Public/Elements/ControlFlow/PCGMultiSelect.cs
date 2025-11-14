namespace AssetTool
{
    [JsonAsset("PCGMultiSelectSettings")]
    public class UPCGMultiSelectSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}