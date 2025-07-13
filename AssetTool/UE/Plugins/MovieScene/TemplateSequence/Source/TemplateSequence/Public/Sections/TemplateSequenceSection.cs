namespace AssetTool
{
    [JsonAsset("TemplateSequenceSection")]
    public class UTemplateSequenceSection : UMovieSceneSubSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}