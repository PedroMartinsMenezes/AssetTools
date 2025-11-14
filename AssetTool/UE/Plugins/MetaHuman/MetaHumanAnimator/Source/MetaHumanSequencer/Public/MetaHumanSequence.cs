namespace AssetTool
{
    [JsonAsset("MetaHumanSceneSequence")]
    public class UMetaHumanSceneSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}