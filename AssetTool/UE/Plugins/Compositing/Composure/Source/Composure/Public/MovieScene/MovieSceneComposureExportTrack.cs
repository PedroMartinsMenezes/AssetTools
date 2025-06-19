namespace AssetTool
{
    [JsonAsset("MovieSceneComposureExportTrack")]
    public class UMovieSceneComposureExportTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneComposureExportSection")]
    public class UMovieSceneComposureExportSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}