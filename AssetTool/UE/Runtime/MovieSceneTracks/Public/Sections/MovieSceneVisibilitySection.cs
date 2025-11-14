namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilitySection")]
    public class UMovieSceneVisibilitySection : UMovieSceneBoolSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}