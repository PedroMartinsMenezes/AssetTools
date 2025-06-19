namespace AssetTool
{
    [JsonAsset("AnimationSequencerDataModel")]
    public class UAnimationSequencerDataModel : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}