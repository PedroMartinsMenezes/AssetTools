namespace AssetTool
{
    [JsonAsset("TemplateSequenceTrack")]
    public class UTemplateSequenceTrack : UMovieSceneSubTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}