namespace AssetTool
{
    [JsonAsset("TemplateSequenceTrack")]
    public class UTemplateSequenceTrack : UMovieSceneSubTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}