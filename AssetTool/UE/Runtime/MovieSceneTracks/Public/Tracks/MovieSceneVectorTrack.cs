namespace AssetTool
{
    [JsonAsset("MovieSceneFloatVectorTrack")]
    public class UMovieSceneFloatVectorTrack : UMovieScenePropertyTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneDoubleVectorTrack")]
    public class UMovieSceneDoubleVectorTrack : UMovieScenePropertyTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}