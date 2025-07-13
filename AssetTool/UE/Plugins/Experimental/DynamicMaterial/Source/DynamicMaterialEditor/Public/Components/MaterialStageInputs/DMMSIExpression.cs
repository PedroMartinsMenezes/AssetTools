namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputExpression")]
    public class UDMMaterialStageInputExpression : UDMMaterialStageInputThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}