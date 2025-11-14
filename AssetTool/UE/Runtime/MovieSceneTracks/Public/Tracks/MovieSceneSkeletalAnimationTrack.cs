namespace AssetTool
{
    [JsonAsset("MovieSceneSkeletalAnimationTrack")]
    public class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}