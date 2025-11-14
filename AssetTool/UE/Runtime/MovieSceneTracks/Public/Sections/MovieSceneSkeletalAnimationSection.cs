namespace AssetTool
{
    [JsonAsset("MovieSceneSkeletalAnimationSection")]
    public class UMovieSceneSkeletalAnimationSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}