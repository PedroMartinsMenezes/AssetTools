namespace AssetTool
{
    [JsonAsset("MetaHumanSceneSequence")]
    public class UMetaHumanSceneSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}