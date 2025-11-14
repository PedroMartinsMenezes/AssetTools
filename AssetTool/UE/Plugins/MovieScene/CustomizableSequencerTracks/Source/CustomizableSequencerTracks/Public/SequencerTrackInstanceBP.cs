namespace AssetTool
{
    [JsonAsset("SequencerTrackInstanceBP")]
    public class USequencerTrackInstanceBP : UMovieSceneTrackInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}