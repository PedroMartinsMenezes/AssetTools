namespace AssetTool
{
    [JsonAsset("DMMaterialStageBlend")]
    public class UDMMaterialStageBlend : UDMMaterialStageThroughput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}