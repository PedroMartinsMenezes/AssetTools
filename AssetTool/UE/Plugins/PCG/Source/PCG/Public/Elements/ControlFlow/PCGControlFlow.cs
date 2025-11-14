namespace AssetTool
{
    [JsonAsset("PCGControlFlowSettings")]
    public class UPCGControlFlowSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}