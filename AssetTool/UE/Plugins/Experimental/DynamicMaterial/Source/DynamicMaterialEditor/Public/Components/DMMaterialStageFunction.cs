namespace AssetTool
{
    [JsonAsset("DMMaterialStageFunction")]
    public class UDMMaterialStageFunction : UDMMaterialStageThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}