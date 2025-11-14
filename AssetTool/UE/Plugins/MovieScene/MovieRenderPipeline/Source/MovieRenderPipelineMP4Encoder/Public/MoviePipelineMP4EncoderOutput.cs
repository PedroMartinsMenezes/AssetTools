namespace AssetTool
{
    [JsonAsset("MoviePipelineMP4EncoderOutput")]
    public class UMoviePipelineMP4EncoderOutput : UMoviePipelineVideoOutputBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}