namespace AssetTool
{
    [JsonAsset("TemplateSequencePlayer")]
    public class UTemplateSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}