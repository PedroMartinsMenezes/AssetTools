namespace AssetTool
{
    [JsonAsset("MovieScene2DTransformSection")]
    public class UMovieScene2DTransformSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}