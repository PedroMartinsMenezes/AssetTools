namespace AssetTool
{
    [JsonAsset("AnimationSequencerDataModel")]
    public class UAnimationSequencerDataModel : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}