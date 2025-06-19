namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilitySection")]
    public class UMovieSceneVisibilitySection : UMovieSceneBoolSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}