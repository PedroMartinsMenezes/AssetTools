namespace AssetTool
{
    [JsonAsset("AnimationSequencerDataModel")]
    public class UAnimationSequencerDataModel : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}