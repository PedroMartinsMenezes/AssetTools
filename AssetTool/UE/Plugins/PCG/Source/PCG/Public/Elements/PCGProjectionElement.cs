namespace AssetTool
{
    [JsonAsset("PCGProjectionSettings")]
    public class UPCGProjectionSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}