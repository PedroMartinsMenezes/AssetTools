namespace AssetTool
{
    [JsonAsset("MoviePipelineEdGraphNodeBase")]
    public class UMoviePipelineEdGraphNodeBase : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineEdGraphNode")]
    public class UMoviePipelineEdGraphNode : UMoviePipelineEdGraphNodeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}