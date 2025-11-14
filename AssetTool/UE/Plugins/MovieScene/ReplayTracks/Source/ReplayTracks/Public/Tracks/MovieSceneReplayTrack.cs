namespace AssetTool
{
    [JsonAsset("MovieSceneReplayTrack")]
    public class UMovieSceneReplayTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}