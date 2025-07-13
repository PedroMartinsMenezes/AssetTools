namespace AssetTool
{
    [JsonAsset("DMMaterialStageGradient")]
    public class UDMMaterialStageGradient : UDMMaterialStageThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}