namespace AssetTool
{
    [JsonAsset("MovieSceneCopyableTrack")]
    public class UMovieSceneCopyableTrack : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}