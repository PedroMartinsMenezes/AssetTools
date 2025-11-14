namespace AssetTool
{
    [JsonAsset("MovieSceneLiveLinkCameraControllerTrackRecorder")]
    public class UMovieSceneLiveLinkCameraControllerTrackRecorder : UMovieSceneLiveLinkControllerTrackRecorder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}