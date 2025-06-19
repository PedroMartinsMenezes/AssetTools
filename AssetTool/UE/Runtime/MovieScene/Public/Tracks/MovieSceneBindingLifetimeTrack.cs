namespace AssetTool
{
    [JsonAsset("MovieSceneBindingLifetimeTrack")]
    public class UMovieSceneBindingLifetimeTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}