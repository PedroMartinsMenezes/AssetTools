namespace AssetTool
{
    [JsonAsset("MovieSceneEventSectionBase")]
    public class UMovieSceneEventSectionBase : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}