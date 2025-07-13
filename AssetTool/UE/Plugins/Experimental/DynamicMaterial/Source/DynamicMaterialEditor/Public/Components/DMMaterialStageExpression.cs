namespace AssetTool
{
    [JsonAsset("DMMaterialStageExpression")]
    public class UDMMaterialStageExpression : UDMMaterialStageThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}