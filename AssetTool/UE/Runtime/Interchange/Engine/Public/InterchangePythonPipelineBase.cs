namespace AssetTool
{
    [JsonAsset("InterchangePythonPipelineBase")]
    public class UInterchangePythonPipelineBase : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePythonPipelineAsset")]
    public class UInterchangePythonPipelineAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}