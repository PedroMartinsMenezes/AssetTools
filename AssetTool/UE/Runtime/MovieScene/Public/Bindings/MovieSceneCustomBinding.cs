namespace AssetTool
{
    [JsonAsset("MovieSceneCustomBinding")]
    public class UMovieSceneCustomBinding : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}