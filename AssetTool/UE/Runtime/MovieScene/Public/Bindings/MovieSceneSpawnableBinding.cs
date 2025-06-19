namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnableBindingBase")]
    public class UMovieSceneSpawnableBindingBase : UMovieSceneCustomBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}