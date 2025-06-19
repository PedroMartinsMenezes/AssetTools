namespace AssetTool
{
    [JsonAsset("MovieSceneByteSection")]
    public class UMovieSceneByteSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}