namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertyTrack")]
    public class UMovieSceneObjectPropertyTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}