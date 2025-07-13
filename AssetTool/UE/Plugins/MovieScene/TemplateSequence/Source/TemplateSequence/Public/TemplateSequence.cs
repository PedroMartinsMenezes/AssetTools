namespace AssetTool
{
    [JsonAsset("TemplateSequence")]
    public class UTemplateSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}