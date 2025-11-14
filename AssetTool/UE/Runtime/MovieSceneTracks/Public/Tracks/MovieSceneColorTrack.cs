namespace AssetTool
{
    [JsonAsset("MovieSceneColorTrack")]
    public class UMovieSceneColorTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}