namespace AssetTool
{
    [JsonAsset("SequencerTrackInstanceBP")]
    public class USequencerTrackInstanceBP : UMovieSceneTrackInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}