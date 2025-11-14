namespace AssetTool
{
    [JsonAsset("MovieSceneRotatorSection")]
    public class UMovieSceneRotatorSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}