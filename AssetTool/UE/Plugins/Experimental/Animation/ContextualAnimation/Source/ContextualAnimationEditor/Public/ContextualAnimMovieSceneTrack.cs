namespace AssetTool
{
    [JsonAsset("ContextualAnimMovieSceneTrack")]
    public class UContextualAnimMovieSceneTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}