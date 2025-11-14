namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnableBindingBase")]
    public class UMovieSceneSpawnableBindingBase : UMovieSceneCustomBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}