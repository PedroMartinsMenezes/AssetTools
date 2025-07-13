namespace AssetTool
{
    [JsonAsset("MovieSceneReplaySection")]
    public class UMovieSceneReplaySection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}