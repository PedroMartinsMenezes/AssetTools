namespace AssetTool
{
    [JsonAsset("NetFaultConfig")]
    public class UNetFaultConfig : UEscalationManagerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}