namespace AssetTool
{
    [JsonAsset("MovieSceneTextTrack")]
    public class UMovieSceneTextTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}