namespace AssetTool
{
    [JsonAsset("SequencerSectionBP")]
    public class USequencerSectionBP : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}