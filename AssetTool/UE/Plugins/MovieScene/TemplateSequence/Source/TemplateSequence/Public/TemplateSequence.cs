namespace AssetTool
{
    [JsonAsset("TemplateSequence")]
    public class UTemplateSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}