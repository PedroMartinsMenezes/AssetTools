namespace AssetTool
{
    [JsonAsset("MovieSceneFadeSection")]
    public class UMovieSceneFadeSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}