namespace AssetTool
{
    [JsonAsset("MovieSceneCopyableBinding")]
    public class UMovieSceneCopyableBinding : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}