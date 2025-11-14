namespace AssetTool
{
    [JsonAsset("DMMaterialStageExpression")]
    public class UDMMaterialStageExpression : UDMMaterialStageThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}