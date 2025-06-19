namespace AssetTool
{
    [JsonAsset("MovieSceneFadeSection")]
    public class UMovieSceneFadeSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}