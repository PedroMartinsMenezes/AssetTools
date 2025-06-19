namespace AssetTool
{
    [JsonAsset("MovieSceneCameraCutTrack")]
    public class UMovieSceneCameraCutTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}