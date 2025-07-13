namespace AssetTool
{
    [JsonAsset("NetFaultConfig")]
    public class UNetFaultConfig : UEscalationManagerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}