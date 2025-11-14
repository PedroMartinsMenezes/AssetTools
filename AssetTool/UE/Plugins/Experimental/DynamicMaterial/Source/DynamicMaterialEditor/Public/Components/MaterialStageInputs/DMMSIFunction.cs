namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputFunction")]
    public class UDMMaterialStageInputFunction : UDMMaterialStageInputThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}