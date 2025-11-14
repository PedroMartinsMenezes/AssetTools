namespace AssetTool
{
    [JsonAsset("SequencerSectionBP")]
    public class USequencerSectionBP : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}