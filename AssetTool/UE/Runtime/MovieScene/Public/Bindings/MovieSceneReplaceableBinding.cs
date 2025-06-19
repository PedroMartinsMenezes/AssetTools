namespace AssetTool
{
    [JsonAsset("MovieSceneReplaceableBindingBase")]
    public class UMovieSceneReplaceableBindingBase : UMovieSceneCustomBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}