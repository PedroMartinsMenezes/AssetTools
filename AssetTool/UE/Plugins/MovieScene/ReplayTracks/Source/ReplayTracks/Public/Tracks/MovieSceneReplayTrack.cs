namespace AssetTool
{
    [JsonAsset("MovieSceneReplayTrack")]
    public class UMovieSceneReplayTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}