namespace AssetTool
{
    [JsonAsset("MovieSceneFloatVectorSection")]
    public class UMovieSceneFloatVectorSection : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneDoubleVectorSection")]
    public class UMovieSceneDoubleVectorSection : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}