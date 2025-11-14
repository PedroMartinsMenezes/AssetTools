namespace AssetTool
{
    [JsonAsset("MovieSceneComposureExportTrack")]
    public class UMovieSceneComposureExportTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneComposureExportSection")]
    public class UMovieSceneComposureExportSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}