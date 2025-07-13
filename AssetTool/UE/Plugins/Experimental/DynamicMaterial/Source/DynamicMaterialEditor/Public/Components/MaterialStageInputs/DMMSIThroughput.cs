namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputThroughput")]
    public class UDMMaterialStageInputThroughput : UDMMaterialStageInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}