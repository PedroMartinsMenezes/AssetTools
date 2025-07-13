namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputGradient")]
    public class UDMMaterialStageInputGradient : UDMMaterialStageInputThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}