namespace AssetTool
{
    [JsonAsset("MovieSceneReplaceableBindingBase")]
    public class UMovieSceneReplaceableBindingBase : UMovieSceneCustomBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}