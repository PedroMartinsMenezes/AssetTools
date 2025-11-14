namespace AssetTool
{
    [JsonAsset("MovieScene2DTransformSection")]
    public class UMovieScene2DTransformSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}