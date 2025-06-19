namespace AssetTool
{
    [JsonAsset("MovieSceneNameableTrack")]
    public class UMovieSceneNameableTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}