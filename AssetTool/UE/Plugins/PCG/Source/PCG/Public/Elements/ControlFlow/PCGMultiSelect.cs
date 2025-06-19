namespace AssetTool
{
    [JsonAsset("PCGMultiSelectSettings")]
    public class UPCGMultiSelectSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}