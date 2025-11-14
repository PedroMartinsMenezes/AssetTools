namespace AssetTool
{
    [JsonAsset("MovieSceneReplaceableActorBinding")]
    public class UMovieSceneReplaceableActorBinding : UMovieSceneReplaceableBindingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneReplaceableActorBinding_BPBase")]
    public class UMovieSceneReplaceableActorBinding_BPBase : UMovieSceneReplaceableBindingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}