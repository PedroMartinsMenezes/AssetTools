namespace AssetTool
{
    [JsonAsset("MovieSceneAnimatorSection")]
    public class UMovieSceneAnimatorSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}