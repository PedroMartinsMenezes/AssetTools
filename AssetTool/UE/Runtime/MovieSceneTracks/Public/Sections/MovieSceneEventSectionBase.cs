namespace AssetTool
{
    [JsonAsset("MovieSceneEventSectionBase")]
    public class UMovieSceneEventSectionBase : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}