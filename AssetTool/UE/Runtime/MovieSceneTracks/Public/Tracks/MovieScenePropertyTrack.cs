namespace AssetTool
{
    [JsonAsset("MovieScenePropertyTrack")]
    public class UMovieScenePropertyTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}