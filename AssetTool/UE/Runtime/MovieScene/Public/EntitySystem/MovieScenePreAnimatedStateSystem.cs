namespace AssetTool
{
    [JsonAsset("MovieSceneCachePreAnimatedStateSystem")]
    public class UMovieSceneCachePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneRestorePreAnimatedStateSystem")]
    public class UMovieSceneRestorePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}