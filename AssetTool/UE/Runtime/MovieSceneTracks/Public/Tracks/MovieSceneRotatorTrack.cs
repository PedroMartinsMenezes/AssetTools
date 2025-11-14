namespace AssetTool
{
    [JsonAsset("MovieSceneRotatorTrack")]
    public class UMovieSceneRotatorTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}