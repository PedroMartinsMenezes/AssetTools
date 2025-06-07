namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilitySection")]
    public class UMovieSceneVisibilitySection : UMovieSceneBoolSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}