namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpTrack")]
    public class UMovieSceneTimeWarpTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}