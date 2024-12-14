namespace AssetTool
{
    [JsonAsset("InterchangePythonPipelineBase")]
    public class UInterchangePythonPipelineBase : UInterchangePipelineBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePythonPipelineAsset")]
    public class UInterchangePythonPipelineAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}