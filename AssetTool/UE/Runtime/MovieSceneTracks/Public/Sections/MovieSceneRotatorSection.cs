namespace AssetTool
{
    [JsonAsset("MovieSceneRotatorSection")]
    public class UMovieSceneRotatorSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}