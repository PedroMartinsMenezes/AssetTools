namespace AssetTool
{
    [JsonAsset("MovieSceneTransformTrack")]
    public class UMovieSceneTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}