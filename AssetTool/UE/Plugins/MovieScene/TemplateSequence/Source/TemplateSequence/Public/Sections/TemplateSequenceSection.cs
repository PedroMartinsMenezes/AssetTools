namespace AssetTool
{
    [JsonAsset("TemplateSequenceSection")]
    public class UTemplateSequenceSection : UMovieSceneSubSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}