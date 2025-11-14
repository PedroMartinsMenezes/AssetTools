namespace AssetTool
{
    [JsonAsset("MovieSceneByteTrack")]
    public class UMovieSceneByteTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}