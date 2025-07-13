namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputFunction")]
    public class UDMMaterialStageInputFunction : UDMMaterialStageInputThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}