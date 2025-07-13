namespace AssetTool
{
    [JsonAsset("EscalationManagerConfig")]
    public class UEscalationManagerConfig : UStatePerObjectConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}