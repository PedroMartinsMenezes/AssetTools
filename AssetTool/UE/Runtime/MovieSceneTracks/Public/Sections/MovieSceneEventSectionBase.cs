namespace AssetTool
{
    [JsonAsset("MovieSceneEventSectionBase")]
    public class UMovieSceneEventSectionBase : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}