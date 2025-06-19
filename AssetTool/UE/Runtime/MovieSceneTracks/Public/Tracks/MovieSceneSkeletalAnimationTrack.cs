namespace AssetTool
{
    [JsonAsset("MovieSceneSkeletalAnimationTrack")]
    public class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}