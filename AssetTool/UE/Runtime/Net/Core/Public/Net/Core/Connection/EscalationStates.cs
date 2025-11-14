namespace AssetTool
{
    [JsonAsset("EscalationManagerConfig")]
    public class UEscalationManagerConfig : UStatePerObjectConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}