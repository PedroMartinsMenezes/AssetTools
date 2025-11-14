namespace AssetTool
{
    [JsonAsset("MovieSceneCameraCutTrack")]
    public class UMovieSceneCameraCutTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}