namespace AssetTool
{
    [JsonAsset("InterchangeGraphInspectorPipeline")]
    public class UInterchangeGraphInspectorPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}