namespace AssetTool
{
    [JsonAsset("TemplateSequencePlayer")]
    public class UTemplateSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}