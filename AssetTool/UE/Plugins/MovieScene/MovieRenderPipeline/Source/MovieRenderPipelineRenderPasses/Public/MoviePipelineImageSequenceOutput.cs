namespace AssetTool
{
    [JsonAsset("MoviePipelineImageSequenceOutputBase")]
    public class UMoviePipelineImageSequenceOutputBase : UMoviePipelineOutputBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineImageSequenceOutput_BMP")]
    public class UMoviePipelineImageSequenceOutput_BMP : UMoviePipelineImageSequenceOutputBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineImageSequenceOutput_PNG")]
    public class UMoviePipelineImageSequenceOutput_PNG : UMoviePipelineImageSequenceOutputBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineImageSequenceOutput_JPG")]
    public class UMoviePipelineImageSequenceOutput_JPG : UMoviePipelineImageSequenceOutputBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}