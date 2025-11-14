namespace AssetTool
{
    [JsonAsset("InterchangeCardsPipeline")]
    public class UInterchangeCardsPipeline : UInterchangePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}