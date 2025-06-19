namespace AssetTool
{
    [JsonAsset("MovieSceneBindingLifetimeSection")]
    public class UMovieSceneBindingLifetimeSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}