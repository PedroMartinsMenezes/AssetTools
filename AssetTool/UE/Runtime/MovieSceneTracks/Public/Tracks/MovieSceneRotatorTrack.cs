namespace AssetTool
{
    [JsonAsset("MovieSceneRotatorTrack")]
    public class UMovieSceneRotatorTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}