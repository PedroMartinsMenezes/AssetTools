namespace AssetTool
{
    [JsonAsset("MovieScene2DTransformTrack")]
    public class UMovieScene2DTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}