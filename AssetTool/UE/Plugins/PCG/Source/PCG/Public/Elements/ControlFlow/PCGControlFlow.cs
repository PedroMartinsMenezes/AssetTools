namespace AssetTool
{
    [JsonAsset("PCGControlFlowSettings")]
    public class UPCGControlFlowSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}