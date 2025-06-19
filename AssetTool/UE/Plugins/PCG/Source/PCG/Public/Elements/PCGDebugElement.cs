namespace AssetTool
{
    [JsonAsset("PCGDebugSettings")]
    public class UPCGDebugSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}