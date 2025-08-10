namespace AssetTool
{
    [JsonAsset("MetaHumanPerformanceSequence")]
    public class UMetaHumanPerformanceSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}