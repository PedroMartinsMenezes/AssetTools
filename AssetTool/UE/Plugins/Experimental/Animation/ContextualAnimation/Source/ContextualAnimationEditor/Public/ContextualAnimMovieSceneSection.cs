namespace AssetTool
{
    [JsonAsset("ContextualAnimMovieSceneSection")]
    public class UContextualAnimMovieSceneSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}