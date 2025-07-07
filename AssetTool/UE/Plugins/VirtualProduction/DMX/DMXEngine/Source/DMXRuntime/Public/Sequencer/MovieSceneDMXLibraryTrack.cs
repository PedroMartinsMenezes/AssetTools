namespace AssetTool
{
    [JsonAsset("MovieSceneDMXLibraryTrack")]
    public class UMovieSceneDMXLibraryTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}