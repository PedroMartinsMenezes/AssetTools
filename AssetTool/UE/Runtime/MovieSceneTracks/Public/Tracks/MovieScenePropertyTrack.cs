namespace AssetTool
{
    [JsonAsset("MovieScenePropertyTrack")]
    public class UMovieScenePropertyTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}