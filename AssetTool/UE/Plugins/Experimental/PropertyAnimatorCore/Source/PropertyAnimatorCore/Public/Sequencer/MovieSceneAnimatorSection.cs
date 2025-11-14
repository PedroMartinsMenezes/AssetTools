namespace AssetTool
{
    [JsonAsset("MovieSceneAnimatorSection")]
    public class UMovieSceneAnimatorSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}