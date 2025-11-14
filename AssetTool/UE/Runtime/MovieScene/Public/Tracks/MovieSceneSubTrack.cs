namespace AssetTool
{
    [JsonAsset("MovieSceneSubTrack")]
    public class UMovieSceneSubTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}