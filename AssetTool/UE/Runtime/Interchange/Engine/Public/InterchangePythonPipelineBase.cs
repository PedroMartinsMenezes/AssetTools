namespace AssetTool
{
    [JsonAsset("InterchangePythonPipelineBase")]
    public class UInterchangePythonPipelineBase : UInterchangePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePythonPipelineAsset")]
    public class UInterchangePythonPipelineAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}