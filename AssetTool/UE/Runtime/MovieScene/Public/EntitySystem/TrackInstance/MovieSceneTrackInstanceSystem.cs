namespace AssetTool
{
    [JsonAsset("MovieSceneTrackInstanceInstantiator")]
    public class UMovieSceneTrackInstanceInstantiator : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneTrackInstanceSystem")]
    public class UMovieSceneTrackInstanceSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}