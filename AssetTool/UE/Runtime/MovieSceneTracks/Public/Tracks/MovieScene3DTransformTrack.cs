namespace AssetTool
{
    [JsonAsset("MovieScene3DTransformTrack")]
    public class UMovieScene3DTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}