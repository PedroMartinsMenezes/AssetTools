namespace AssetTool
{
    [JsonAsset("MoviePipelineEdGraphNodeBase")]
    public class UMoviePipelineEdGraphNodeBase : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineEdGraphNode")]
    public class UMoviePipelineEdGraphNode : UMoviePipelineEdGraphNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}