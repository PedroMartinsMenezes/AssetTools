namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputThroughput")]
    public class UDMMaterialStageInputThroughput : UDMMaterialStageInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}