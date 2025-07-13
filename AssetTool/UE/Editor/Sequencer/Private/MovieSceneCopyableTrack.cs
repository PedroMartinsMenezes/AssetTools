namespace AssetTool
{
    [JsonAsset("MovieSceneCopyableTrack")]
    public class UMovieSceneCopyableTrack : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}