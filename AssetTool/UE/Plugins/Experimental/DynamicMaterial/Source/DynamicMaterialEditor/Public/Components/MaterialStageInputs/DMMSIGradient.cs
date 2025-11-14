namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputGradient")]
    public class UDMMaterialStageInputGradient : UDMMaterialStageInputThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}