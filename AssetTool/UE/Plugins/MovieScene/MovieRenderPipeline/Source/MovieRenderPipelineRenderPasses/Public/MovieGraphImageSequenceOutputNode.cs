namespace AssetTool
{
    [JsonAsset("MovieGraphImageSequenceOutputNode")]
    public class UMovieGraphImageSequenceOutputNode : UMovieGraphFileOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphImageSequenceOutputNode_EXR")]
    public class UMovieGraphImageSequenceOutputNode_EXR : UMovieGraphImageSequenceOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphImageSequenceOutputNode_MultiLayerEXR")]
    public class UMovieGraphImageSequenceOutputNode_MultiLayerEXR : UMovieGraphImageSequenceOutputNode_EXR
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphImageSequenceOutputNode_BMP")]
    public class UMovieGraphImageSequenceOutputNode_BMP : UMovieGraphImageSequenceOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphImageSequenceOutputNode_JPG")]
    public class UMovieGraphImageSequenceOutputNode_JPG : UMovieGraphImageSequenceOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphImageSequenceOutputNode_PNG")]
    public class UMovieGraphImageSequenceOutputNode_PNG : UMovieGraphImageSequenceOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}