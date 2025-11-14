namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputExpression")]
    public class UDMMaterialStageInputExpression : UDMMaterialStageInputThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}