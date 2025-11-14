namespace AssetTool
{
    [JsonAsset("DMMaterialStageGradient")]
    public class UDMMaterialStageGradient : UDMMaterialStageThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}