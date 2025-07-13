namespace AssetTool
{
    [JsonAsset("MovieSceneMediaTrack")]
    public class UMovieSceneMediaTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}