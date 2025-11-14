namespace AssetTool
{
    [JsonAsset("MovieSceneStringTrack")]
    public class UMovieSceneStringTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}