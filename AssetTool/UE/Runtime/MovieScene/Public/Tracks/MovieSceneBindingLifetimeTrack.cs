namespace AssetTool
{
    [JsonAsset("MovieSceneBindingLifetimeTrack")]
    public class UMovieSceneBindingLifetimeTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}