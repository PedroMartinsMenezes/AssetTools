namespace AssetTool
{
    [JsonAsset("PCGGetExecutionContextSettings")]
    public class UPCGGetExecutionContextSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}