namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnableActorBindingBase")]
    public class UMovieSceneSpawnableActorBindingBase : UMovieSceneSpawnableBindingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneSpawnableActorBinding")]
    public class UMovieSceneSpawnableActorBinding : UMovieSceneSpawnableActorBindingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}