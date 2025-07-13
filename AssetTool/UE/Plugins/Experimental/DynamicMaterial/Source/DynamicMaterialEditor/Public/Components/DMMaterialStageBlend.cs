namespace AssetTool
{
    [JsonAsset("DMMaterialStageBlend")]
    public class UDMMaterialStageBlend : UDMMaterialStageThroughput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}