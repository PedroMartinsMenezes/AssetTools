namespace AssetTool
{
    [JsonAsset("DMMaterialStageFunction")]
    public class UDMMaterialStageFunction : UDMMaterialStageThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}