namespace AssetTool
{
    [JsonAsset("MovieSceneReplaceableBindingBase")]
    public class UMovieSceneReplaceableBindingBase : UMovieSceneCustomBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}