namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnableBindingBase")]
    public class UMovieSceneSpawnableBindingBase : UMovieSceneCustomBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}