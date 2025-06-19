namespace AssetTool
{
    [JsonAsset("PCGAddComponentSettings")]
    public class UPCGAddComponentSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}