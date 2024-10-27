namespace AssetTool
{
    [JsonAsset("MovieScene3DTransformSectionConstraints")]
    public class  UMovieScene3DTransformSectionConstraints : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScene3DTransformSection")]
    public class  UMovieScene3DTransformSection : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}