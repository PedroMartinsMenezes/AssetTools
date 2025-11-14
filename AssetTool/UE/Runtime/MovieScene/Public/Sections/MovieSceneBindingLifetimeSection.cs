namespace AssetTool
{
    [JsonAsset("MovieSceneBindingLifetimeSection")]
    public class UMovieSceneBindingLifetimeSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}