namespace AssetTool
{
    [JsonAsset("PCGGetExecutionContextSettings")]
    public class UPCGGetExecutionContextSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}