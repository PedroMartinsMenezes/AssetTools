namespace AssetTool
{
    [JsonAsset("MovieSceneDMXLibraryTrack")]
    public class UMovieSceneDMXLibraryTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}