namespace AssetTool
{
    [JsonAsset("MovieSceneMediaTrack")]
    public class UMovieSceneMediaTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}